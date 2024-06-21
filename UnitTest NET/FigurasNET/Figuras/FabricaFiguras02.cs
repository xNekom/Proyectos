namespace FigurasNET.Figuras;

public class FabricaFiguras02 : IFiguraBuilder
{
    public IFigura dameFigura(TipoFigura tipoFigura)
    {
        return new Cuadrado(8);
    }
}