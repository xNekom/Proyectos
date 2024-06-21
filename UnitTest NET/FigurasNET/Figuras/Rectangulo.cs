namespace FigurasNET.Figuras;

public class Rectangulo : IFigura
{
    private readonly int lado1;
    private readonly int lado2;

    public Rectangulo(int lado1, int lado2)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
    }

    public decimal dameArea()
    {
        return lado1 * lado2;
    }

    public decimal damePerimetro()
    {
        return lado1 * 2 + lado2 * 2;
    }
}