/*
Implementar una clase que gestione la lista de empleados, permitiendo registrar, listar y buscar
empleados, así como calcular el salario de cada uno.
*/

package GestionEmpleados;

import java.util.ArrayList;

public class GestorEmpleados {

    ArrayList<IEmpleado> ListaEmpleados;

    public GestorEmpleados() {
        this.ListaEmpleados = new ArrayList<>();
    }

    public void registrarEmpleado(IEmpleado empleado) {
        this.ListaEmpleados.add(empleado);
    }

    public void listarEmpleados() {
        for (IEmpleado empleado : ListaEmpleados) {
            System.out.println(empleado.mostrarEmpleado());
        }
    }

    public void buscarEmpleados(IEmpleado empleado) {
        if (this.ListaEmpleados.contains(empleado) == true) {
            System.out.println(empleado.mostrarEmpleado());
        }
        else {
            System.out.println("No se encontró el empleado");
        }
    }
}
