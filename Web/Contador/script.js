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
  contador.textContent = valorActual;
}

function actualizarEstadisticas() {
  let suma = 0;
  let cantidad = historial.length;
  valorMaximo = Math.max(...historial);
  valorMinimo = Math.min(...historial);
  for (let i = 0; i < cantidad; i++) {
    suma += historial[i];
  }
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
  listaHistorial.appendChild(item);
}
