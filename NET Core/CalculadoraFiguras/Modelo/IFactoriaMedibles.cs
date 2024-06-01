namespace CalculadoraFiguras.Modelo;

// Interfaz IFactoriaMedibles
public interface IFactoriaMedibles
{
    IMedible dameFigura(TipoFigura tipo, int valor);
}