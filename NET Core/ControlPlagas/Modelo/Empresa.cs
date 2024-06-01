using ControlPlagas.Enum;
using ControlPlagas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Modelo
{
    public class Empresa : IEmpresa
    {
        private List<IServicio> _servicios = new List<IServicio>();
        private List<ITrabajador> _trabajadores = new List<ITrabajador>();
        private List<IVeneno> _venenos = new List<IVeneno>();
        private List<IRecurso> _recursos = new List<IRecurso>();

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
}
