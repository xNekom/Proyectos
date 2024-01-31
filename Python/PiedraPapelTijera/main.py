import random

print("Bienvenido al juego de piedra, papel o tijera!")
print("Elije tu opción:")
print("1. Piedra")
print("2. Papel")
print("3. Tijera")

# Inicializar variables
jugador_ganadas = 0
computadora_ganadas = 0
rondas_jugadas = 0

# Bucle principal
while True:
    print(f"\nRonda {rondas_jugadas + 1}")
    jugador = int(input("Ingresa el número de tu elección: "))
    computadora = random.randint(1, 3)

    if computadora == 1:
        opcion_computadora = "Piedra"
    elif computadora == 2:
        opcion_computadora = "Papel"
    else:
        opcion_computadora = "Tijera"

    if jugador == computadora:
        print("Empate. Ambos eligieron", opcion_computadora)
    elif (jugador == 1 and computadora == 3) or (jugador == 2 and computadora == 1) or (jugador == 3 and computadora == 2):
        print("¡Ganaste! La computadora eligió", opcion_computadora)
        jugador_ganadas += 1
    else:
        print("Perdiste. La computadora eligió", opcion_computadora)
        computadora_ganadas += 1

    rondas_jugadas += 1

    # Verificar si se han jugado 3 rondas
    if rondas_jugadas == 3:
        print("\nResultados finales:")
        print(f"Jugador: {jugador_ganadas} victorias")
        print(f"Computadora: {computadora_ganadas} victorias")
        if jugador_ganadas > computadora_ganadas:
            print("¡Felicidades! ¡Ganaste el juego!")
        elif jugador_ganadas < computadora_ganadas:
            print("Lo siento, perdiste el juego.")
        else:
            print("El juego terminó en empate.")
        break
