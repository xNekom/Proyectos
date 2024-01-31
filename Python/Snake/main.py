# Juego de serpiente en Python con PyGame

import pygame
import random

pygame.init()

NEGRO = (0, 0, 0)
BLANCO = (255, 255, 255)
ROJO = (255, 0, 0)
VERDE = (0, 255, 0)

ANCHO = 600
ALTO = 600

pantalla = pygame.display.set_mode((ANCHO, ALTO))

pygame.display.set_caption("Juego de serpiente")

reloj = pygame.time.Clock()

TAM = 20

vel_x = TAM
vel_y = 0

serpiente = [(ANCHO // 2, ALTO // 2)]

fruta = (random.randrange(0, ANCHO - TAM, TAM), random.randrange(0, ALTO - TAM, TAM))

jugando = True

game_over = False

def mostrar_mensaje(texto, color, x, y, tam):
    fuente = pygame.font.SysFont(None, tam)
    mensaje = fuente.render(texto, True, color)
    pantalla.blit(mensaje, (x, y))

while jugando:
    for evento in pygame.event.get():
        if evento.type == pygame.QUIT:
            jugando = False
        elif evento.type == pygame.KEYDOWN:
            if evento.key == pygame.K_LEFT:
                vel_x = -TAM
                vel_y = 0
            elif evento.key == pygame.K_RIGHT:
                vel_x = TAM
                vel_y = 0
            elif evento.key == pygame.K_UP:
                vel_x = 0
                vel_y = -TAM
            elif evento.key == pygame.K_DOWN:
                vel_x = 0
                vel_y = TAM

    if not game_over:
        cabeza_x = serpiente[0][0] + vel_x
        cabeza_y = serpiente[0][1] + vel_y
        cabeza = (cabeza_x, cabeza_y)

        if cabeza_x < 0 or cabeza_x >= ANCHO or cabeza_y < 0 or cabeza_y >= ALTO or cabeza in serpiente:
            game_over = True
        else:
            serpiente.insert(0, cabeza)

            if cabeza == fruta:
                fruta = (random.randrange(0, ANCHO - TAM, TAM), random.randrange(0, ALTO - TAM, TAM))
            else:
                serpiente.pop()

    pantalla.fill(NEGRO)

    for x, y in serpiente:
        pygame.draw.rect(pantalla, VERDE, (x, y, TAM, TAM))

    pygame.draw.rect(pantalla, ROJO, (fruta[0], fruta[1], TAM, TAM))

    if game_over:
        mostrar_mensaje("Game Over", BLANCO, ANCHO // 2 - 50, ALTO // 2 - 10, 30)
        mostrar_mensaje("Presiona R para reiniciar", BLANCO, ANCHO // 2 - 80, ALTO // 2 + 20, 20)
        if evento.type == pygame.KEYDOWN:
            if evento.key == pygame.K_r:
                vel_x = TAM
                vel_y = 0
                serpiente = [(ANCHO // 2, ALTO // 2)]
                fruta = (random.randrange(0, ANCHO - TAM, TAM), random.randrange(0, ALTO - TAM, TAM))
                game_over = False

    pygame.display.flip()

    reloj.tick(10)

pygame.quit()
