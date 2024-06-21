namespace FigurasNET.Figuras;

public class FabricaDeFiguras01 : IFiguraBuilder
{
    public IFigura dameFigura(TipoFigura tipoFigura)
    {
        switch (tipoFigura)
        {
            case TipoFigura.Cuadrado: return new Cuadrado(2);
            case TipoFigura.Rectangulo: return new Rectangulo(2, 6);
            case TipoFigura.Triangulo: return new Triangulo(2, 4, 6);
            default: return null;
        }
    }
}