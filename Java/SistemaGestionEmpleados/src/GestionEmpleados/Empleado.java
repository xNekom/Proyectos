package GestionEmpleados;

public abstract class Empleado implements IEmpleado {
    protected String nombre;
    protected double salarioBase;

    @Override
    public void registrarEmpleado(String nombre, double salario) {
        if (nombre.length() > 2 && nombre.length() < 50 && salario >= 1080.0) {
            this.nombre = nombre;
            this.salarioBase = salario;
        } else {
            System.out.println("El nombre no puede tener más de 50 caracteres y el salario debe ser mínimo de 1080€");
        }
    }

    @Override
    public String mostrarEmpleado() {
        return "Datos del empleado:\n" +
                "Nombre: " + nombre +
                "\n, Salario: " + salarioBase;
    }

    public abstract void setNombre(String pNombre);

    @Override
    public double calcularSalario() {
        return salarioBase;
    }

    public abstract void setSalario(double pSalario);
}
