namespace CalculadoraFiguras.Modelo;

// Clase Cuadrado
public class Cuadrado : IMedible
{
    private readonly int lado;

    public Cuadrado(int lado)
    {
        this.lado = lado;
    }

    public double dameSuperficie()
    {
        return lado * lado;
    }

    public double damePerimetro()
    {
        return 4 * lado;
    }
}