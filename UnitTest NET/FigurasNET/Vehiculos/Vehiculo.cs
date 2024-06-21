using FigurasNET.Vehiculos.Motores;
using FigurasNET.Vehiculos.Ruedas;

namespace FigurasNET.Vehiculos;

/// <summary>
///     Clase por composición compuesta por un motor y unas ruedas
/// </summary>
public class Vehiculo
{
    public Vehiculo(IMotor motorDelVehiculo, IRueda ruedasDelVehiculo)
    {
        MotorDelVehiculo1 = motorDelVehiculo;
        RuedasDelVehiculo1 = ruedasDelVehiculo;
    }

    public IMotor MotorDelVehiculo1 { get; set; }

    public IRueda RuedasDelVehiculo1 { get; set; }
}