using FigurasNET.Vehiculos.Motores;

namespace FigurasNET.Test.Vehiculos.Motores;

[TestClass]
public class MotorNuclearTests
{
    [TestMethod]
    public void TestGetPotencia()
    {
        IMotor motor = new MotorNuclear(78, 100);

        var potencia = motor.damePotencia();

        Assert.AreEqual(7800, potencia);
    }

    [TestMethod]
    public void TestGetCoste()
    {
        IMotor motor = new MotorNuclear(78, 100);

        var coste = motor.dameCoste();

        Assert.AreEqual(100, coste);
    }
}