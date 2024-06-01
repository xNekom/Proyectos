using System;
using System.Collections.Generic;
using System.Linq;

    using System;
    using SistemaDefensa.Modelo;

    namespace SistemaDefensa
    {
        class Program
        {
            static void Main(string[] args)
            {
                Ejercito ejercito = new Ejercito(50000);

                try
                {
                    IUnidadMilitar transporte = FabricaUnidadesMilitares.CrearUnidad("Transporte");
                    ejercito.AgregarUnidad(transporte);

                    IUnidadMilitar tanqueAtaque = FabricaUnidadesMilitares.CrearUnidad("TanqueAtaque");
                    ejercito.AgregarUnidad(tanqueAtaque);

                    IUnidadMilitar transporteRapido = FabricaUnidadesMilitares.CrearUnidad("TransporteRapido");
                    ejercito.AgregarUnidad(transporteRapido);

                    IUnidadMilitar infanteriaBasica = FabricaUnidadesMilitares.CrearUnidad("InfanteriaBasica");
                    ejercito.AgregarUnidad(infanteriaBasica);

                    IUnidadMilitar ametrallador = FabricaUnidadesMilitares.CrearUnidad("Ametrallador");
                    ejercito.AgregarUnidad(ametrallador);

                    IUnidadMilitar sanitario = FabricaUnidadesMilitares.CrearUnidad("Sanitario");
                    ejercito.AgregarUnidad(sanitario);

                    IUnidadMilitar canionAntiaereo = FabricaUnidadesMilitares.CrearUnidad("CanionAntiaereo");
                    ejercito.AgregarUnidad(canionAntiaereo);

                    IUnidadMilitar torpedoMovil = FabricaUnidadesMilitares.CrearUnidad("TorpedoMovil");
                    ejercito.AgregarUnidad(torpedoMovil);

                    IUnidadMilitar canon = FabricaUnidadesMilitares.CrearUnidad("Canion");
                    ejercito.AgregarUnidad(canon);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine($"Cantidad de unidades: {ejercito.CantidadUnidades()}");
                Console.WriteLine($"Potencia de fuego total: {ejercito.PotenciaFuegoTotal()}");
                Console.WriteLine($"Blindaje total: {ejercito.BlindajeTotal()}");
                Console.WriteLine($"Capacidad de movimiento: {ejercito.CapacidadMovimiento()}");
                Console.WriteLine($"Dinero gastado: {ejercito.DineroGastado()}");
                Console.WriteLine($"Capacidad militar: {ejercito.CapacidadMilitar()}");
            }
        }
    }