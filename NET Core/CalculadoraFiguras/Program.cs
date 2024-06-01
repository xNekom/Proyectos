/*Vamos a crear una interface para crearnos una jerarquia (IMedible), lo que vamos a querer es saber cual es la superficie 
y el perimetro de algo.
Por tanto en la interface, pondremos los dos siguientes métodos.
dameSuperficie()
damePerimetro()
Creamos una clase cuadrado y otra clase Circulo, en ambas ocasiones voy a proporcionar un solo valor de tipo entero que es 
el lado en el caso del cuadrado y el radio en el caso del circulo.
Como no sabemos en tiempo de ejecución si vamos a poner cuadrados o circulos, crearemos una clase Factoria, que implementará 
la siguiente interface.
IFactoriaMedibles
IMedible dameFigura (int tipo, int valor);
Como pueden crecer los numeros de figuras, vamos a crear una enumeración en la que pondremos Cuadrado o Circulo.
Crear un cuadrado y un circulo con este nuevo sistema.
Si queréis podeis inyectar un visualizador en vuestra clase.
Un tablero de figuras para saber, cuantas figuras hay, cual es la superficie total, cual es el perimetro, cual es la figura 
más pequeña, cual es la más grande, cual es la media de superficie y de perimetro.*/


using CalculadoraFiguras.Modelo;
using System;

class Program
{
    static void Main(string[] args)
    {
        IFactoriaMedibles factoria = new Factoria();

        IMedible cuadrado1 = factoria.dameFigura(TipoFigura.Cuadrado, 5);
        IMedible circulo1 = factoria.dameFigura(TipoFigura.Circulo, 3);
        IMedible cuadrado2 = factoria.dameFigura(TipoFigura.Cuadrado, 7);
        IMedible circulo2 = factoria.dameFigura(TipoFigura.Circulo, 4);

        IVisualizador visualizador = new ConsoleVisualizador();
        TableroFiguras tablero = new TableroFiguras(visualizador);

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