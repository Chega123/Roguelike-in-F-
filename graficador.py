import pygame
import sys
import random
import time

# Función para cargar la vida, el arma y la matriz desde el archivo de texto
def load_game_state(file_path):
    try:
        with open(file_path, 'r') as file:
            lines = file.readlines()
            if len(lines) < 3:  # Verificar que haya al menos 3 líneas (vida, arma y al menos una línea de la matriz)
                raise ValueError("El archivo no tiene el formato esperado.")
            vida = int(lines[0].strip())
            arma = lines[1].strip()
            id_room =lines[2].strip()
            matrix = [list(line.strip()) for line in lines[3:]]
            return vida, arma, id_room, matrix
    except Exception as e:
        print(f"Error al cargar el estado del juego: {e}")
        return None, None,None, []

# Función para cargar las imágenes en un diccionario
def load_images():
    numero_aleatorio = random.randint(1, 3)
    image_map = {
        'w': pygame.image.load(f'sprites/pared/{numero_aleatorio}.jpg'),
        'f': pygame.image.load(f'sprites/piso/{numero_aleatorio}.jpg'),
        's': pygame.image.load(f'sprites/puas/{numero_aleatorio}.jpg'),
        'a': pygame.image.load('sprites/abismo/abismo.jpg'),
        '2': pygame.image.load(f'sprites/jugador/{numero_aleatorio}.jpg'),
        'R': pygame.image.load(f'sprites/enemigo/rata{numero_aleatorio}.jpg'),
        '3': pygame.image.load(f'sprites/puerta/{numero_aleatorio}.jpg'),
        'G': pygame.image.load(f'sprites/enemigo/gobling{numero_aleatorio}.jpg'),
        'L': pygame.image.load(f'sprites/enemigo/lobo{numero_aleatorio}.jpg'),
        'O': pygame.image.load(f'sprites/enemigo/orco{numero_aleatorio}.jpg'),
        'T': pygame.image.load(f'sprites/enemigo/troll{numero_aleatorio}.jpg'),
        'E': pygame.image.load(f'sprites/enemigo/esqueleto{numero_aleatorio}.jpg'),
        'Z': pygame.image.load(f'sprites/enemigo/zombie{numero_aleatorio}.jpg'),
        'B': pygame.image.load(f'sprites/enemigo/brujo{numero_aleatorio}.jpg'),
        'P': pygame.image.load(f'sprites/enemigo/espectro{numero_aleatorio}.jpg'),
        '5': pygame.image.load('sprites/Armas/espada.jpg'),
        '6': pygame.image.load('sprites/Armas/lanza.jpg'),
        '7': pygame.image.load('sprites/Armas/arco.jpg'),
        '8': pygame.image.load('sprites/Armas/mandoble.jpg'),
        '9': pygame.image.load('sprites/Armas/daga.jpg'),
        '*': pygame.image.load('sprites/Armas/Chayanne.jpg'),
        '&': pygame.image.load('sprites/enemigo/dragonrojo.jpg'),
        '%': pygame.image.load('sprites/enemigo/golempiedra.jpg'),
        '$': pygame.image.load('sprites/enemigo/senorcaos.jpg'),

        # Agrega más letras e imágenes según sea necesario
    }
    return image_map

# Función para dibujar la matriz usando Pygame
def draw_matrix(matrix, screen, cell_size, image_map):
    for i, row in enumerate(matrix):
        for j, cell in enumerate(row):
            image = image_map.get(cell)  # Obtener la imagen correspondiente a la letra
            if image:
                # Escalar la imagen al tamaño de la celda
                image = pygame.transform.scale(image, (cell_size, cell_size))
                # Dibujar la imagen en la posición correcta
                screen.blit(image, (j * cell_size, i * cell_size + 80))  # +80 para dejar espacio en la parte superior

# Tamaño de la ventana y celda
WINDOW_WIDTH = 600
WINDOW_HEIGHT = 700
CELL_SIZE = 40

# Ruta del archivo de texto que contiene la vida, el arma y la matriz
file_path = 'map.txt'

# Inicializar Pygame
pygame.init()
screen = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))
clock = pygame.time.Clock()

# Cargar las imágenes
image_map = load_images()

# Configurar fuente para el texto
font = pygame.font.Font(None, 36)
game_over_font = pygame.font.Font(None, 72)

# Bucle principal
game_over = False
victoria=False
while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            sys.exit()
    
    if not game_over and not victoria:
        # Cargar la vida, el arma y la matriz en cada iteración del bucle
        vida, arma,id_room, matrix = load_game_state(file_path)
        print (id_room)
        if vida is None or arma is None:
            # Si hubo un error al cargar el estado del juego, continuar con la siguiente iteración
            time.sleep(0.1)
            continue

        if vida <= 0:
            victoria=False
            game_over = True

        if int(id_room) ==9:
            game_over = False
            victoria=True
    
    screen.fill((0, 0, 0))  # Limpiar la pantalla antes de dibujar la nueva matriz

    
    if game_over:
        # Dibujar la pantalla de Game Over
        game_over_text = game_over_font.render('GAME OVER', True, (255, 0, 0))
        screen.blit(game_over_text, (WINDOW_WIDTH // 2 - game_over_text.get_width() // 2, WINDOW_HEIGHT // 2 - game_over_text.get_height() // 2))
    elif victoria:
        # Dibujar la pantalla de Victoria
        victory_text = game_over_font.render('VICTORY!', True, (0, 255, 0))  # Texto "VICTORY!" en verde
        screen.blit(victory_text, (WINDOW_WIDTH // 2 - victory_text.get_width() // 2, WINDOW_HEIGHT // 2 - victory_text.get_height() // 2))

    else:
        # Dibujar la vida en la parte superior de la pantalla
        vida_text = font.render(f'Vida: {vida}', True, (255, 255, 255))
        screen.blit(vida_text, (10, 10))
        
        # Dibujar la imagen del arma en la esquina superior derecha
        arma_image = pygame.image.load(f'sprites/Armas/{arma}.jpg')
        arma_image = pygame.transform.scale(arma_image, (50, 50))  # Ajustar el tamaño según sea necesario
        screen.blit(arma_image, (WINDOW_WIDTH - arma_image.get_width() - 10, 10))
        
        # Dibujar la matriz
        draw_matrix(matrix, screen, CELL_SIZE, image_map)
    
    pygame.display.update()
    clock.tick(60)  # Controla la velocidad del bucle
