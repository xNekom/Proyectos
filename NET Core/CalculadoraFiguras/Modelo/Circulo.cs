namespace CalculadoraFiguras.Modelo;

// Clase Círculo
public class Circulo : IMedible
{
    private readonly int radio;

    public Circulo(int radio)
    {
        this.radio = radio;
    }

    public double dameSuperficie()
    {
        return Math.PI * radio * radio;
    }

    public double damePerimetro()
    {
        return 2 * Math.PI * radio;
    }
}