package GestionEmpleados;

public interface IEmpleado {
    void registrarEmpleado(String nombre, double salario);
    String mostrarEmpleado();
    double calcularSalario();
}
