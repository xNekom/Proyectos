using CalculadoraFiguras.Modelo;

internal class Program
{
    private static void Main(string[] args)
    {
        IFactoriaMedibles factoria = new Factoria();

        var cuadrado1 = factoria.dameFigura(TipoFigura.Cuadrado, 5);
        var circulo1 = factoria.dameFigura(TipoFigura.Circulo, 3);
        var cuadrado2 = factoria.dameFigura(TipoFigura.Cuadrado, 7);
        var circulo2 = factoria.dameFigura(TipoFigura.Circulo, 4);

        IVisualizador visualizador = new ConsoleVisualizador();
        var tablero = new TableroFiguras(visualizador);

        tablero.AgregarFigura(cuadrado1);
        tablero.AgregarFigura(circulo1);
        tablero.AgregarFigura(cuadrado2);
        tablero.AgregarFigura(circulo2);

        Console.WriteLine($"Superficie total: {tablero.SuperficieTotal()}");
        Console.WriteLine($"Perímetro total: {tablero.PerimetroTotal()}");
        Console.WriteLine($"Figura más grande: {tablero.FiguraMasGrande().GetType().Name}");
        Console.WriteLine($"Figura más pequeña: {tablero.FiguraMasPequena().GetType().Name}");
        Console.WriteLine($"Superficie promedio: {tablero.SuperficiePromedio()}");
        Console.WriteLine($"Perímetro promedio: {tablero.PerimetroPromedio()}");
    }
}

public class ConsoleVisualizador : IVisualizador
{
    public void DibujarFigura(IMedible figura)
    {
        Console.WriteLine($"Se ha dibujado una figura de tipo {figura.GetType().Name}");
    }
}