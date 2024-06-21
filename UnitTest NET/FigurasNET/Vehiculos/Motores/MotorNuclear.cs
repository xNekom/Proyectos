namespace FigurasNET.Vehiculos.Motores;

public class MotorNuclear : IMotor
{
    private readonly double potencia;
    private readonly double precio;

    public MotorNuclear(double potencia, double precio)
    {
        this.potencia = potencia;
        this.precio = precio;
    }

    public double dameCoste()
    {
        return precio;
    }

    public double damePotencia()
    {
        return potencia * 100;
    }
}