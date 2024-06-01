using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class Ametrallador : IUnidadMilitar
    {
        public string Nombre { get; set; } = "Ametrallador";
        public IVelocidad Velocidad { get; set; }
        public IBlindaje Blindaje { get; set; } = new BlindajeNulo();
        public IPotenciaFuego PotenciaFuego { get; set; }
        public double Precio { get; set; } = 400;

        public Ametrallador()
        {
            Velocidad = new VelocidadMedia(4);
            PotenciaFuego = new PotenciaFuegoAlta(10);
        }
    }
}
