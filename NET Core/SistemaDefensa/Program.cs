using SistemaDefensa.Modelo;

namespace SistemaDefensa;

internal class Program
{
    private static void Main(string[] args)
    {
        var ejercito = new Ejercito(50000);

        try
        {
            var transporte = FabricaUnidadesMilitares.CrearUnidad("Transporte");
            ejercito.AgregarUnidad(transporte);

            var tanqueAtaque = FabricaUnidadesMilitares.CrearUnidad("TanqueAtaque");
            ejercito.AgregarUnidad(tanqueAtaque);

            var transporteRapido = FabricaUnidadesMilitares.CrearUnidad("TransporteRapido");
            ejercito.AgregarUnidad(transporteRapido);

            var infanteriaBasica = FabricaUnidadesMilitares.CrearUnidad("InfanteriaBasica");
            ejercito.AgregarUnidad(infanteriaBasica);

            var ametrallador = FabricaUnidadesMilitares.CrearUnidad("Ametrallador");
            ejercito.AgregarUnidad(ametrallador);

            var sanitario = FabricaUnidadesMilitares.CrearUnidad("Sanitario");
            ejercito.AgregarUnidad(sanitario);

            var canionAntiaereo = FabricaUnidadesMilitares.CrearUnidad("CanionAntiaereo");
            ejercito.AgregarUnidad(canionAntiaereo);

            var torpedoMovil = FabricaUnidadesMilitares.CrearUnidad("TorpedoMovil");
            ejercito.AgregarUnidad(torpedoMovil);

            var canon = FabricaUnidadesMilitares.CrearUnidad("Canion");
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