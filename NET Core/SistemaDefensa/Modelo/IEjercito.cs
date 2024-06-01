using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
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
}
