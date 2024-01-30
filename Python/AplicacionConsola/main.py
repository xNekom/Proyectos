"""
Proyecto Python-MySQL:
- Abrir asistente
- Login o registro
- Si elegimos registro, creará un usuario en la bbdd
- Si elegimos login, identifica al usuario y nos preguntará
- Crear nota, mostrar notas, borrarlas.
"""
from usuarios import acciones

print("""
Acciones disponibles:
    - 1. Registro
    - 2. Login
""")

hazEl = acciones.Acciones()
accion = input("Selecciona una opción: ")

if accion == "1":
    hazEl.registro()

elif accion == "2":
    hazEl.login()
