const formIsValid = () => {
  if (colorFavorito === "") {
    alert("Debe seleccionar un color favorito.");
    return false;
  }

  if (fechaNacimiento === "") {
    alert("Debe introducir su fecha de nacimiento.");
    return false;
  }

  if (cita === "") {
    alert("Debe introducir una cita.");
    return false;
  }

  if (foto === undefined) {
    alert("Debe seleccionar un archivo para subir.");
    return false;
  }

  if (mes === "") {
    alert("Debe introducir un mes.");
    return false;
  }

  if (edad === "") {
    alert("Debe introducir su edad.");
    return false;
  }

  if (opcion === undefined) {
    alert("Debe seleccionar una opción.");
    return false;
  }

  if (nivel === "") {
    alert("Debe introducir un nivel de satisfacción.");
    return false;
  }

  if (telefono === "") {
    alert("Debe introducir un número de teléfono.");
    return false;
  }

  if (url === "") {
    alert("Debe introducir una dirección web.");
    return false;
  }

  if (semana === "") {
    alert("Debe introducir una semana.");
    return false;
  }

  if (!esEmailValido || !acepta) {
    alert("Debe completar correctamente el email y aceptar los términos.");
    return false;
  }

  return true;
};

const submitForm = () => {
  if (formIsValid()) {
    alert("Formulario enviado correctamente.");
  } else {
    alert("Formulario no válido. Revise los errores.");
  }
};

document.getElementById("submit").addEventListener("click", submitForm);
