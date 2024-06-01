import GestionEmpleados.*;

public class Main {
    public static void main(String[] args) {

        GestorEmpleados gestorEmpleados = new GestorEmpleados();

        EmpleadoAsalariado empleadoAsalariado1 = new EmpleadoAsalariado("Juan", 3000.0, 5.0, 10.0);
        EmpleadoAsalariado empleadoAsalariado2 = new EmpleadoAsalariado("María", 2000.0, 1.0, 25.0);
        EmpleadoComision empleadoComision1 = new EmpleadoComision("Pepe", 2500.0, 30.0, 0.10);
        EmpleadoComision empleadoComision2 = new EmpleadoComision("Paca", 2500.0, 20.0, 0.10);
        EmpleadoPorHoras empleadoPorHoras1 = new EmpleadoPorHoras("Paco", 2000.0, 16.0, 25.0);
        EmpleadoPorHoras empleadoPorHoras2 = new EmpleadoPorHoras("Tranchete", 2000.0, 16.0, 25.0);

        EmpleadoAsalariado empleadoAsalariado4 = new EmpleadoAsalariado("Felipe", 3000.0, 5.0, 10.0);

        gestorEmpleados.registrarEmpleado(empleadoAsalariado1);
        gestorEmpleados.registrarEmpleado(empleadoAsalariado2);
        gestorEmpleados.registrarEmpleado(empleadoComision1);
        gestorEmpleados.registrarEmpleado(empleadoComision2);
        gestorEmpleados.registrarEmpleado(empleadoPorHoras1);
        gestorEmpleados.registrarEmpleado(empleadoPorHoras2);

        gestorEmpleados.listarEmpleados();

        gestorEmpleados.buscarEmpleados(empleadoAsalariado1);
        gestorEmpleados.buscarEmpleados(empleadoComision1);
        gestorEmpleados.buscarEmpleados(empleadoPorHoras1);
        gestorEmpleados.buscarEmpleados(empleadoAsalariado4);
    }
}