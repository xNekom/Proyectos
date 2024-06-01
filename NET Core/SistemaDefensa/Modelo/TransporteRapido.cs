using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class TransporteRapido : IUnidadMilitar
    {
        public string Nombre { get; set; } = "TAXIN-66";
        public IVelocidad Velocidad { get; set; }
        public IBlindaje Blindaje { get; set; } = new BlindajeNulo();
        public IPotenciaFuego PotenciaFuego { get; set; } = new PotenciaFuegoNula();
        public double Precio { get; set; } = 1600;

        public TransporteRapido()
        {
            Velocidad = new VelocidadAlta(12);
        }
    }
}
