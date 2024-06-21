namespace FigurasNET.Figuras;

public class Triangulo : IFigura
{
    private readonly int lado1;
    private readonly int lado2;
    private readonly int lado3;

    public Triangulo(int lado1, int lado2, int lado3)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
    }

    public decimal dameArea()
    {
        double semiperimetro = (lado1 + lado2 + lado3) / 2;
        var area = Math.Sqrt(
            semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));
        return (decimal)area;
    }

    public decimal damePerimetro()
    {
        return lado1 + lado2 + lado3;
    }
}