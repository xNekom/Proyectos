const contador = document.getElementById("contador");
const listaHistorial = document.getElementById("lista-historial");
const maximo = document.getElementById("maximo");
const minimo = document.getElementById("minimo");
const promedio = document.getElementById("promedio");
const tendencia = document.getElementById("tendencia");

let historial = [];
let valorMaximo = 0;
let valorMinimo = 0;
let valorPromedio = 0;

// Inicializar el contador al cargar la página
document.addEventListener("DOMContentLoaded", function() {
  contador.textContent = 0;
});

function sumar() {
  let valorActual = parseInt(contador.textContent);
  valorActual++;
  contador.textContent = valorActual;
  actualizarEstadisticas();
  agregarHistorial("suma");
}

function restar() {
  let valorActual = parseInt(contador.textContent);
  valorActual--;
  contador.textContent = valorActual;
  actualizarEstadisticas();
  agregarHistorial("resta");
}

function actualizarEstadisticas() {
  let suma = 0;
  let cantidad = historial.length;
  valorMaximo = Math.max(...historial);
  valorMinimo = Math.min(...historial);
  // Usar el método reduce para sumar los valores del historial
  suma = historial.reduce((a, b) => a + b, 0);
  valorPromedio = suma / cantidad;
  maximo.textContent = valorMaximo;
  minimo.textContent = valorMinimo;
  promedio.textContent = valorPromedio.toFixed(2);
  if (historial[cantidad - 1] > historial[cantidad - 2]) {
    tendencia.textContent = "↑";
  } else if (historial[cantidad - 1] < historial[cantidad - 2]) {
    tendencia.textContent = "↓";
  } else {
    tendencia.textContent = "→";
  }
}

function agregarHistorial(tipo) {
  let valorActual = parseInt(contador.textContent);
  historial.push(valorActual);
  let item = document.createElement("li");
  item.textContent = tipo + ": " + valorActual;
  // Usar el método prepend para añadir el elemento al principio de la lista
  listaHistorial.prepend(item);
}
