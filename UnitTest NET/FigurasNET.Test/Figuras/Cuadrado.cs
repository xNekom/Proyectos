using FigurasNET.Figuras;

namespace FigurasNET.Tests;

[TestClass]
public class CuadradoTests
{
    [TestMethod]
    public void CalculaAreaCorrectamente()
    {
        var lado = 5;
        var cuadrado = new Cuadrado(lado);

        var area = cuadrado.dameArea();

        Assert.AreEqual(25m, area);
    }

    [TestMethod]
    public void CalculaPerimetroCorrectamente()
    {
        var lado = 5;
        var cuadrado = new Cuadrado(lado);

        var perimetro = cuadrado.damePerimetro();

        Assert.AreEqual(20m, perimetro);
    }
}