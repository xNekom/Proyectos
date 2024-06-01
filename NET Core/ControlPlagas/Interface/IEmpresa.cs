using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Interface
{
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
}
