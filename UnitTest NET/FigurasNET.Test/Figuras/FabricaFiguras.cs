using FigurasNET.Figuras;

namespace FigurasNET.Tests;

[TestClass]
public class FabricaDeFiguras01Tests
{
    private FabricaDeFiguras01 fabrica;

    [TestInitialize]
    public void Setup()
    {
        fabrica = new FabricaDeFiguras01();
    }

    [TestMethod]
    public void TestDameFigura_Cuadrado()
    {
        var figura = fabrica.dameFigura(TipoFigura.Cuadrado);
        Assert.IsInstanceOfType(figura, typeof(Cuadrado));
        Assert.AreEqual(4, ((Cuadrado)figura).dameArea());
    }

    [TestMethod]
    public void TestDameFigura_Rectangulo()
    {
        var figura = fabrica.dameFigura(TipoFigura.Rectangulo);
        Assert.IsInstanceOfType(figura, typeof(Rectangulo));
        Assert.AreEqual(12, ((Rectangulo)figura).dameArea());
    }

    [TestMethod]
    public void TestDameFigura_Triangulo()
    {
        var figura = fabrica.dameFigura(TipoFigura.Triangulo);
        Assert.IsInstanceOfType(figura, typeof(Triangulo));
    }

    [TestMethod]
    public void TestDameFigura_TipoInvalido()
    {
        var figura = fabrica.dameFigura((TipoFigura)999);
        Assert.IsNull(figura);
    }
}

[TestClass]
public class FabricaFiguras02Tests
{
    private FabricaFiguras02 fabrica;

    [TestInitialize]
    public void Setup()
    {
        fabrica = new FabricaFiguras02();
    }

    [TestMethod]
    public void TestDameFigura_SiempreCuadrado()
    {
        var figuraCuadrado = fabrica.dameFigura(TipoFigura.Cuadrado);
        Assert.IsInstanceOfType(figuraCuadrado, typeof(Cuadrado));
        Assert.AreEqual(64, ((Cuadrado)figuraCuadrado).dameArea());

        var figuraRectangulo = fabrica.dameFigura(TipoFigura.Rectangulo);
        Assert.IsInstanceOfType(figuraRectangulo, typeof(Cuadrado));
        Assert.AreEqual(64, ((Cuadrado)figuraRectangulo).dameArea());

        var figuraTriangulo = fabrica.dameFigura(TipoFigura.Triangulo);
        Assert.IsInstanceOfType(figuraTriangulo, typeof(Cuadrado));
        Assert.AreEqual(64, ((Cuadrado)figuraTriangulo).dameArea());
    }
}