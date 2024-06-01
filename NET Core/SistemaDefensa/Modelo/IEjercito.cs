namespace SistemaDefensa.Modelo;

public interface IEjercito
{
    void AgregarUnidad(IUnidadMilitar unidad);
    int CantidadUnidades();
    double PotenciaFuegoTotal();
    double BlindajeTotal();
    double CapacidadMovimiento();
    double DineroGastado();
    double CapacidadMilitar();
}