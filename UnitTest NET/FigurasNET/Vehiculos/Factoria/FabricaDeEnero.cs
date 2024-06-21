﻿using FigurasNET.Vehiculos.Motores;
using FigurasNET.Vehiculos.Ruedas;

namespace FigurasNET.Vehiculos.Factoria;

public class FabricaDeEnero : IFactoriaVehiculos
{
    public Vehiculo dameVehiculo(TipoVehiculo tipoVehiculo)
    {
        switch (tipoVehiculo)
        {
            case TipoVehiculo.NuclearDeCompeticion:
                return new Vehiculo(new MotorNuclear(78, 100), new RuedaCompeticion(1));
            case TipoVehiculo.Normal:
                return new Vehiculo(new MotorEstandar(78, 100), new RuedaNormal("normal", 89));
            default:
                return null;
        }
    }
}