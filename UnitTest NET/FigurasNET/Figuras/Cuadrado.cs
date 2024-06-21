namespace FigurasNET.Figuras;

public class Cuadrado : IFigura
{
    public int lado;

    public Cuadrado(int lado)
    {
        this.lado = lado;
    }

    public decimal dameArea()
    {
        return lado * lado;
    }

    public decimal damePerimetro()
    {
        return lado * 4;
    }
}