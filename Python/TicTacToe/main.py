# Tic Tac Toe game in Python

tablero = [" " for i in range(9)]

def imprimir_tablero():
    fila1 = "| {} | {} | {} |".format(tablero[0], tablero[1], tablero[2])
    fila2 = "| {} | {} | {} |".format(tablero[3], tablero[4], tablero[5])
    fila3 = "| {} | {} | {} |".format(tablero[6], tablero[7], tablero[8])

    print()
    print(fila1)
    print(fila2)
    print(fila3)
    print()

def comprobar_ganador(simbolo):
    if tablero[0] == tablero[1] == tablero[2] == simbolo:
        return True
    if tablero[3] == tablero[4] == tablero[5] == simbolo:
        return True
    if tablero[6] == tablero[7] == tablero[8] == simbolo:
        return True
    if tablero[0] == tablero[3] == tablero[6] == simbolo:
        return True
    if tablero[1] == tablero[4] == tablero[7] == simbolo:
        return True
    if tablero[2] == tablero[5] == tablero[8] == simbolo:
        return True
    if tablero[0] == tablero[4] == tablero[8] == simbolo:
        return True
    if tablero[2] == tablero[4] == tablero[6] == simbolo:
        return True
    return False

def comprobar_llena():
    for i in range(9):
        if tablero[i] == " ":
            return False
    return True

def obtener_movimiento(simbolo):
    print("Es tu turno, " + simbolo + ".")
    while True:
        try:
            move = int(input("Introduce un número entre 1 y 9: ")) - 1
            if move < 0 or move > 8:
                print("Número inválido. Inténtalo de nuevo.")
            elif tablero[move] != " ":
                print("Ese espacio ya está ocupado. Prueba otro.")
            else:
                return move
        except ValueError:
            print("Eso no es un número. Inténtalo de nuevo.")

def jugar():
    imprimir_tablero()
    while True:
        move_x = obtener_movimiento("X")
        tablero[move_x] = "X"
        imprimir_tablero()
        if comprobar_ganador("X"):
            print("X gana!")
            break
        if comprobar_llena():
            print("Es un empate!")
            break
        move_o = obtener_movimiento("O")
        tablero[move_o] = "O"
        imprimir_tablero()
        if comprobar_ganador("O"):
            print("O gana!")
            break
        if comprobar_llena():
            print("Es un empate!")
            break

jugar()
