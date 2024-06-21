using FigurasNET.Vehiculos.Motores;

namespace FigurasNET.Test.Vehiculos.Motores;

[TestClass]
public class MotorEstandarTests
{
    [TestMethod]
    public void TestGetPotencia()
    {
        IMotor motor = new MotorEstandar(78, 100);

        var potencia = motor.damePotencia();

        Assert.AreEqual(78, potencia);
    }

    [TestMethod]
    public void TestGetCoste()
    {
        IMotor motor = new MotorEstandar(78, 100);

        var coste = motor.dameCoste();

        Assert.AreEqual(100, coste);
    }
}