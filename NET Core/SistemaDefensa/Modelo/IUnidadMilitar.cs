using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public interface IUnidadMilitar
    {
        string Nombre { get; set; }
        IVelocidad Velocidad { get; set; }
        IBlindaje Blindaje { get; set; }
        IPotenciaFuego PotenciaFuego { get; set; }
        double Precio { get; set; }
    }
}
