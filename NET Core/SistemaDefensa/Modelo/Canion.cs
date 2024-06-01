using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class Canion : IUnidadMilitar
    {
        public string Nombre { get; set; } = "Cañon";
        public IVelocidad Velocidad { get; set; } = new VelocidadNula();
        public IBlindaje Blindaje { get; set; } = new BlindajeNulo();
        public IPotenciaFuego PotenciaFuego { get; set; }
        public double Precio { get; set; } = 1100;

        public Canion()
        {
            PotenciaFuego = new PotenciaFuegoBaja(14);
        }
    }
}
