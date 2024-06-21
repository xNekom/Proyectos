using FigurasNET.Vehiculos.Motores;
using FigurasNET.Vehiculos.Ruedas;

namespace FigurasNET.Vehiculos.Factoria;

[TestClass]
public class FabricaDeEneroTests
{
    [TestMethod]
    public void TestCreacionVehiculoNormal()
    {
        IFactoriaVehiculos fabrica = new FabricaDeEnero();

        var vehiculo = fabrica.dameVehiculo(TipoVehiculo.Normal);

        Assert.IsNotNull(vehiculo);
        Assert.IsInstanceOfType(vehiculo.MotorDelVehiculo1, typeof(MotorEstandar));
        Assert.IsInstanceOfType(vehiculo.RuedasDelVehiculo1, typeof(RuedaNormal));
    }

    [TestMethod]
    public void TestCreacionVehiculoNuclearDeCompeticion()
    {
        IFactoriaVehiculos fabrica = new FabricaDeEnero();

        var vehiculo = fabrica.dameVehiculo(TipoVehiculo.NuclearDeCompeticion);

        Assert.IsNotNull(vehiculo);
        Assert.IsInstanceOfType(vehiculo.MotorDelVehiculo1, typeof(MotorNuclear));
        Assert.IsInstanceOfType(vehiculo.RuedasDelVehiculo1, typeof(RuedaCompeticion));
    }
}