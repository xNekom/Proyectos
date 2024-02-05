let pantalla = document.getElementById("pantalla");
let primerNumero = "";
let segundoNumero = "";
let operadorActual = ""; // Cambio de nombre para evitar colisiones

function numero(numero) {
    if (operadorActual === "") {
        primerNumero += numero;
    } else {
        segundoNumero += numero;
    }
    pantalla.value = primerNumero + operadorActual + segundoNumero;
}

function establecerOperador(operador) { // Cambio de nombre
    if (primerNumero !== "") {
        operadorActual = operador;
        pantalla.value = primerNumero + operadorActual + segundoNumero;
    }
}

function punto() {
    if (operadorActual === "") {
        if (!primerNumero.includes(".")) {
            primerNumero += ".";
        }
    } else {
        if (!segundoNumero.includes(".")) {
            segundoNumero += ".";
        }
    }
    pantalla.value = primerNumero + operadorActual + segundoNumero;
}

function igual() {
    if (primerNumero !== "" && segundoNumero !== "") {
        switch (operadorActual) {
            case "+":
                resultado = parseFloat(primerNumero) + parseFloat(segundoNumero);
                break;
            case "-":
                resultado = parseFloat(primerNumero) - parseFloat(segundoNumero);
                break;
            case "*":
                resultado = parseFloat(primerNumero) * parseFloat(segundoNumero);
                break;
            case "/":
                resultado = parseFloat(primerNumero) / parseFloat(segundoNumero);
                break;
        }
        pantalla.value = resultado;
        primerNumero = resultado;
        segundoNumero = "";
        operadorActual = "";
    }
}
