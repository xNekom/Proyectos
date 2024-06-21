using FigurasNET.Vehiculos;
using FigurasNET.Vehiculos.Motores;
using FigurasNET.Vehiculos.Ruedas;

namespace FigurasNET.Tests;

[TestClass]
public class VehiculoTests
{
    [TestMethod]
    public void VehiculoSeCreaCorrectamente()
    {
        var motor = new TestMotor(78, 100);
        var rueda = new TestRueda("normal", 89);

        var vehiculo = new Vehiculo(motor, rueda);

        Assert.IsNotNull(vehiculo);
        Assert.AreEqual(motor, vehiculo.MotorDelVehiculo1);
        Assert.AreEqual(rueda, vehiculo.RuedasDelVehiculo1);
    }

    [TestMethod]
    public void PuedeCambiarMotor()
    {
        var motor1 = new TestMotor(78, 100);
        var motor2 = new TestMotor(100, 150);
        var rueda = new TestRueda("normal", 89);
        var vehiculo = new Vehiculo(motor1, rueda);

        vehiculo.MotorDelVehiculo1 = motor2;

        Assert.AreEqual(motor2, vehiculo.MotorDelVehiculo1);
    }

    [TestMethod]
    public void PuedeCambiarRuedas()
    {
        var motor = new TestMotor(78, 100);
        var rueda1 = new TestRueda("normal", 89);
        var rueda2 = new TestRueda("deportiva", 120);
        var vehiculo = new Vehiculo(motor, rueda1);

        vehiculo.RuedasDelVehiculo1 = rueda2;

        Assert.AreEqual(rueda2, vehiculo.RuedasDelVehiculo1);
    }
}

public class TestMotor : IMotor
{
    private readonly double coste;
    private readonly double potencia;

    public TestMotor(double potencia, double coste)
    {
        this.potencia = potencia;
        this.coste = coste;
    }

    public double damePotencia()
    {
        return potencia;
    }

    public double dameCoste()
    {
        return coste;
    }
}

public class TestRueda : IRueda
{
    private readonly double coste;
    private readonly string goma;

    public TestRueda(string goma, double coste)
    {
        this.goma = goma;
        this.coste = coste;
    }

    public string dameGoma()
    {
        return goma;
    }

    public double dameCoste()
    {
        return coste;
    }
}