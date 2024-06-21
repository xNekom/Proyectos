using FigurasNET.Vehiculos.Ruedas;

namespace FigurasNET.Test.Vehiculos.Ruedas;

[TestClass]
public class RuedaCompeticionTests
{
    [TestMethod]
    public void TestGetGoma()
    {
        IRueda rueda = new RuedaCompeticion(0.5);

        var goma = rueda.dameGoma();

        Assert.AreEqual("competicion", goma);
    }

    [TestMethod]
    public void TestGetCoste()
    {
        IRueda rueda = new RuedaCompeticion(0.5);

        var coste = rueda.dameCoste();

        Assert.AreEqual(11, coste);
    }
}