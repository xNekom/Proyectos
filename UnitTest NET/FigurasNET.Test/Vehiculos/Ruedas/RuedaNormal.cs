using FigurasNET.Vehiculos.Ruedas;

namespace FigurasNET.Test.Vehiculos.Ruedas;

[TestClass]
public class RuedaNormalTests
{
    [TestMethod]
    public void TestGetGoma()
    {
        IRueda rueda = new RuedaNormal("normal", 89);

        var goma = rueda.dameGoma();

        Assert.AreEqual("normal", goma);
    }

    [TestMethod]
    public void TestGetCoste()
    {
        IRueda rueda = new RuedaNormal("normal", 89);

        var coste = rueda.dameCoste();

        Assert.AreEqual(89, coste);
    }
}