var contador = document.getElementById("contador");

var valor = 0;

function sumar() {
  valor++;
  contador.innerHTML = valor;
  cambiarColor();
}

function restar() {
  valor--;
  contador.innerHTML = valor;
  cambiarColor();
}

function cambiarColor() {
  if (valor > 0) {
    contador.style.color = "green";
  }
  else if (valor < 0) {
    contador.style.color = "red";
  }
  else {
    contador.style.color = "black";
  }
}
