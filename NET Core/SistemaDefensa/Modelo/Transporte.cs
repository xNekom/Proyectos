using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class Transporte : IUnidadMilitar
    {
        public string Nombre { get; set; } = "MX-7899";
        public IVelocidad Velocidad { get; set; }
        public IBlindaje Blindaje { get; set; }
        public IPotenciaFuego PotenciaFuego { get; set; } = new PotenciaFuegoNula();
        public double Precio { get; set; } = 4200;

        public Transporte()
        {
            Velocidad = new VelocidadMedia(4.5);
            Blindaje = new BlindajeBajo(1.4);
        }
    }
}
