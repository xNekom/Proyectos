namespace ControlPlagas.Interface;

public interface IEmpresa
{
    void AgregarServicio(IServicio servicio);
    void AgregarTrabajador(ITrabajador trabajador);
    void AgregarVeneno(IVeneno veneno);
    void AgregarRecurso(IRecurso recurso);
    decimal CalcularIngresoTotal();
    decimal CalcularGastoTotal();
    decimal CalcularResultado();
}