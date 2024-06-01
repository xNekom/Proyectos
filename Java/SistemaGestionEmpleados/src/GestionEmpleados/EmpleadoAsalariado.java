package GestionEmpleados;

public class EmpleadoAsalariado extends Empleado {
    private double horasTrabajadas;

    public EmpleadoAsalariado(String nombre, double salario, double horasTrabajadas, double importePorHora) {
        this.setNombre(nombre);
        this.setSalario(salario);
        this.horasTrabajadas = horasTrabajadas;
    }

    @Override
    public String mostrarEmpleado() {
        return "Datos del empleado:\n" +
                "Nombre: " + nombre +
                "\nHoras trabajadas: " + horasTrabajadas +
                "\n, Salario: " + salarioBase;
    }

    @Override
    public void setNombre(String pNombre) {
        if (pNombre.length() > 2 && pNombre.length() < 50) {
            this.nombre = pNombre;
        } else {
            System.out.println("El nombre no puede tener más de 50 caracteres");
        }
    }

    @Override
    public void setSalario(double pSalario) {
        if (pSalario < 1080) {
            System.out.println("El SMI es de 1080 €");
        }
        else {
            this.salarioBase = pSalario;
        }
    }

    public double getHorasTrabajadas() {
        return horasTrabajadas;
    }

    public void setHorasTrabajadas(double pHorasTrabajadas) {
        if (pHorasTrabajadas > 0 && pHorasTrabajadas < 40) {
            this.horasTrabajadas = pHorasTrabajadas;
        } else {
            System.out.println("No intentes explotar al trabajador. El máximo de horas trabajadas es 8");
        }
    }
}
