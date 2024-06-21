using FigurasNET.Figuras;

namespace FigurasNET.Tests;

[TestClass]
public class RectanguloTests
{
    [TestMethod]
    public void TestCalcularArea()
    {
        var rectangulo = new Rectangulo(5, 3);

        var area = rectangulo.dameArea();

        Assert.AreEqual(15, area);
    }

    [TestMethod]
    public void CalculaPerimetroCorrectamente()
    {
        // Arrange
        var lado1 = 5;
        var lado2 = 10;
        var rectangulo = new Rectangulo(lado1, lado2);

        // Act
        var perimetro = rectangulo.damePerimetro();

        // Assert
        Assert.AreEqual(30m, perimetro);
    }
}