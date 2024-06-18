import pygame
import sys
import time
import random
import string
# Función para cargar la matriz desde el archivo de texto
def load_matrix_from_file(file_path):
    with open(file_path, 'r') as file:
        lines = file.readlines()
        matrix = [list(line.strip()) for line in lines]
        return matrix

# Función para cargar las imágenes en un diccionario
def load_images():
    numero_aleatorio = random.randint(1, 3)
    image_map = {
        'w': pygame.image.load('sprites/pared/' + str(numero_aleatorio) + '.jpg'),
        'f': pygame.image.load('sprites/piso/' + str(numero_aleatorio) + '.jpg'),
        's': pygame.image.load('sprites/puas/' + str(numero_aleatorio) + '.jpg'),
        'a': pygame.image.load('sprites/abismo/abismo.jpg'),
        '2': pygame.image.load('sprites/jugador/' + str(numero_aleatorio) + '.jpg'),
        'R': pygame.image.load('sprites/enemigo/rata' + str(numero_aleatorio) + '.jpg'),
        '3': pygame.image.load('sprites/puerta/' + str(numero_aleatorio) + '.jpg'),
        'G': pygame.image.load('sprites/enemigo/gobling' + str(numero_aleatorio) + '.jpg'),
        'L': pygame.image.load('sprites/enemigo/lobo' + str(numero_aleatorio) + '.jpg'),
        'O': pygame.image.load('sprites/enemigo/orco' + str(numero_aleatorio) + '.jpg'),
        'T': pygame.image.load('sprites/enemigo/troll' + str(numero_aleatorio) + '.jpg'),
        'E': pygame.image.load('sprites/enemigo/esqueleto' + str(numero_aleatorio) + '.jpg'),
        'Z': pygame.image.load('sprites/enemigo/zombie' + str(numero_aleatorio) + '.jpg'),
        'B': pygame.image.load('sprites/enemigo/brujo' + str(numero_aleatorio) + '.jpg'),
        '♫': pygame.image.load('sprites/enemigo/espectro' + str(numero_aleatorio) + '.jpg')
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
                screen.blit(image, (j * cell_size, i * cell_size))

# Tamaño de la ventana y celda
WINDOW_WIDTH = 600
WINDOW_HEIGHT = 600
CELL_SIZE = 40

# Ruta del archivo de texto que contiene la matriz
file_path = 'map.txt'

# Inicializar Pygame
pygame.init()
screen = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))
clock = pygame.time.Clock()

# Cargar las imágenes
image_map = load_images()

# Bucle principal
while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            sys.exit()
    
    # Cargar y dibujar la matriz en cada iteración del bucle
    matrix = load_matrix_from_file(file_path)
    screen.fill((0, 0, 0))  # Limpiar la pantalla antes de dibujar la nueva matriz
    draw_matrix(matrix, screen, CELL_SIZE, image_map)
    
    pygame.display.update()
    clock.tick(60)  # Controla la velocidad del bucle
# Añadir una pausa para evitar leer el archivo con demasiada frecuencia
