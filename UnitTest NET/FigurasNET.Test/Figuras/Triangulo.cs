using FigurasNET.Figuras;

namespace FigurasNET.Test.Figuras;

[TestClass]
public class TrianguloTests
{
    private readonly Triangulo triangulo = new(3, 4, 5);

    [TestMethod]
    public void TestCalcularArea()
    {
        Assert.AreEqual(6, triangulo.dameArea());
    }

    [TestMethod]
    public void TestCalcularPerimetro()
    {
        Assert.AreEqual(12, triangulo.damePerimetro());
    }
}