using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class Sanitario : IUnidadMilitar
    {
        public string Nombre { get; set; } = "Sanitario";
        public IVelocidad Velocidad { get; set; }
        public IBlindaje Blindaje { get; set; }
        public IPotenciaFuego PotenciaFuego { get; set; } = new PotenciaFuegoNula();
        public double Precio { get; set; } = 500;

        public Sanitario()
        {
            Velocidad = new VelocidadMedia(7);
            Blindaje = new BlindajeAlto(5);
        }
    }
}
