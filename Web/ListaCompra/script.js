// Obtenemos los elementos del DOM
const form = document.getElementById("form");
const item = document.getElementById("item");
const price = document.getElementById("price");
const add = document.getElementById("add");
const list = document.getElementById("list");
const clear = document.getElementById("clear");

// Creamos una variable para almacenar el total de la compra
let total = 0;

// Añadimos un evento al botón de añadir
add.addEventListener("click", function(event) {
    // Evitamos que se recargue la página
    event.preventDefault();
    // Obtenemos los valores del elemento y el precio
    let itemValue = item.value;
    let priceValue = parseFloat(price.value);
    // Comprobamos que no estén vacíos
    if (itemValue && priceValue) {
        // Creamos una fila para la tabla con el elemento y el precio
        let row = document.createElement("tr");
        let itemCell = document.createElement("td");
        let priceCell = document.createElement("td");
        itemCell.textContent = itemValue;
        priceCell.textContent = priceValue.toFixed(2) + " €";
        row.appendChild(itemCell);
        row.appendChild(priceCell);
        // Añadimos la fila a la tabla
        list.appendChild(row);
        // Actualizamos el total de la compra
        total += priceValue;
        // Limpiamos los campos del formulario
        item.value = "";
        price.value = "";
    }
});

// Añadimos un evento al botón de borrar todo
clear.addEventListener("click", function() {
    // Borramos todas las filas de la tabla
    list.innerHTML = "<thead><tr><th>Elemento</th><th>Precio</th></tr></thead><tbody></tbody>";
    // Reseteamos el total de la compra
    total = 0;
});

// Añadimos un evento al final de la página para mostrar el total de la compra
window.addEventListener("beforeunload", function(event) {
    // Mostramos un mensaje con el total de la compra
    event.returnValue = "El total de tu compra es " + total.toFixed(2) + " €. ¿Estás seguro de que quieres salir?";
});
