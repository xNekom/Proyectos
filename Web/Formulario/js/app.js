function validarFormulario() {
  // Obtener los valores del formulario
  var nombre = document.getElementById("nombre").value;
  var email = document.getElementById("email").value;
  var mensaje = document.getElementById("mensaje").value;

  // Validar el formato del correo electrónico
  var regexEmail= /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  var esEmailValido = regexEmail.test(email);

  // Mostrar mensaje de error si el correo electrónico no es válido

  var emailError = document.getElementById("emailError");


  if (!esEmailValido) {
    emailError.innerHTML = "Ingrese un correo electrónico válido.";
  } else {
    emailError.innerHTML = ""; // Limpiar el mensaje de error si es válido
    // Aquí puedes enviar el formulario o realizar otras acciones si es válido
    alert("Formulario enviado correctamente.");
  }
  if(nombre === ' '){
    nombreError.innerHTML = "Ingrese un nombre válido";
    retorno = false;
    alert ("Nombre no válido")
  }   else nombreError.innerHTML="";


  if(password === ''){
    passwordError.innerHTML = "Ingrese una contraseña válida";
    retorno = false;
  }   else passwordErrorError.innerHTML="";

  if(email === ''){
    emailError.innerHTML = "Ingrese un Email válido";
    retorno = false;
  }   else if (!regexEmail.test(email)){
    error.Email.innerHTML="Ingrese un correo válido"
  }   else emailError.innerHTML = "";
  if (mensaje===''){
    mensajeError.innerHTML="Ingrese un Mensaje válido";
    retorno=false;
  }   else mensajeError.innerHTML="";
  return retorno;
}
