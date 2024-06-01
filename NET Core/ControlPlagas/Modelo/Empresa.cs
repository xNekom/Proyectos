using ControlPlagas.Enum;
using ControlPlagas.Interface;

namespace ControlPlagas.Modelo;

public class Empresa : IEmpresa
{
    private readonly List<IRecurso> _recursos = new();
    private readonly List<IServicio> _servicios = new();
    private readonly List<ITrabajador> _trabajadores = new();
    private readonly List<IVeneno> _venenos = new();

    public void AgregarServicio(IServicio servicio)
    {
        _servicios.Add(servicio);
    }

    public void AgregarTrabajador(ITrabajador trabajador)
    {
        _trabajadores.Add(trabajador);
    }

    public void AgregarVeneno(IVeneno veneno)
    {
        _venenos.Add(veneno);
    }

    public void AgregarRecurso(IRecurso recurso)
    {
        _recursos.Add(recurso);
    }

    public decimal CalcularIngresoTotal()
    {
        return _servicios.Sum(s => s.Ingreso);
    }

    public decimal CalcularGastoTotal()
    {
        var gastoEquipos = _servicios.Sum(s => s.Equipo.Gasto);
        var gastoGerentes = _trabajadores.Where(t => t.Tipo == TipoTrabajador.Gerente).Sum(t => t.Ingreso);
        var gastoVenenos = _venenos.Sum(v => v.Cantidad * v.CostoUnidad);
        var gastoRecursos = _recursos.Sum(r => r.CostoServicio);
        return gastoEquipos + gastoGerentes + gastoVenenos + gastoRecursos;
    }

    public decimal CalcularResultado()
    {
        return CalcularIngresoTotal() - CalcularGastoTotal();
    }
}