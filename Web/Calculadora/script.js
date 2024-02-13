let display = document.getElementById("display");
let currentNumber = "";
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
    case "+":
      display.value = firstOperand + secondOperand;
      break;
    case "-":
      display.value = firstOperand - secondOperand;
      break;
    case "*":
      display.value = firstOperand * secondOperand;
      break;
    case "/":
      display.value = firstOperand / secondOperand;
      break;
  }
  operator = null;
  waitingForSecondOperand = false;
}

function clearDisplay() {
  display.value = "";
}
