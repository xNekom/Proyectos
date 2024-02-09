let display = document.getElementById('display');
let currentNumber = '';
let operator = null;
let firstOperand = null;
let waitingForSecondOperand = false;

function appendNumber(number) {
    if (waitingForSecondOperand) {
        display.value = number;
        waitingForSecondOperand = false;
    } else {
        display.value = display.value + number;
    }
}

function appendOperator(op) {
    if (operator !== null) calculate();
    firstOperand = parseFloat(display.value);
    operator = op;
    waitingForSecondOperand = true;
}

function calculate() {
    let secondOperand = parseFloat(display.value);
    switch (operator) {
        case '+':
            display.value = firstOperand + secondOperand;
            break;
        case '-':
            display.value = firstOperand - secondOperand;
            break;
        case '*':
            display.value = firstOperand * secondOperand;
            break;
        case '/':
            display.value = firstOperand / secondOperand;
            break;
    }
    operator = null;
    waitingForSecondOperand = false;
}

function clearDisplay() {
    display.value = '';
}

/*
let display = document.getElementById('display');: Selecciona el elemento de entrada con el ID 'display' y lo almacena
en la variable display.

let currentNumber = ''; let operator = null; let firstOperand = null; let waitingForSecondOperand = false;: Estas son
variables que almacenan el número actual, el operador seleccionado, el primer operando y un booleano que indica si se
está esperando un segundo operando.

function appendNumber(number) {...}: Esta función se llama cuando se hace clic en un botón de número. Si se está
esperando un segundo operando, se establece el valor del display al número y se establece waitingForSecondOperand a
false. Si no, se añade el número al valor actual del display.

function appendOperator(op) {...}: Esta función se llama cuando se hace clic en un botón de operador. Si ya hay un
operador seleccionado, se realiza el cálculo. Luego, se establece el primer operando al valor actual del display, se
establece el operador al operador seleccionado y se establece waitingForSecondOperand a true.

function calculate() {...}: Esta función realiza el cálculo. Se establece el segundo operando al valor actual del
display, luego se realiza el cálculo según el operador seleccionado y se muestra el resultado en el display. Finalmente,
se restablece el operador y waitingForSecondOperand.

function clearDisplay() {...}: Esta función se llama cuando se hace clic en el botón 'C'. Limpia el display
estableciendo su valor a una cadena vacía.

En resumen, este código JavaScript proporciona la funcionalidad para la calculadora, permitiendo a los usuarios
introducir números, seleccionar un operador, realizar cálculos y limpiar el display.
*/