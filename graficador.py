import pygame
import sys

# Función para cargar la matriz desde el archivo de texto
def load_matrix_from_file(file_path):
    with open(file_path, 'r') as file:
        lines = file.readlines()
        matrix = [list(line.strip()) for line in lines]
        return matrix

# Función para cargar las imágenes en un diccionario
def load_images():
    image_map = {
        'w': pygame.image.load('sprites/pared/1.jpg'),
        'f': pygame.image.load('sprites/piso/1.jpg'),
        's': pygame.image.load('sprites/puas/1.jpg')
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

# Cargar y dibujar la matriz
matrix = load_matrix_from_file(file_path)
draw_matrix(matrix, screen, CELL_SIZE, image_map)

# Bucle principal
while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            sys.exit()

    pygame.display.update()
    clock.tick(60)
