using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class InfanteriaBasica : IUnidadMilitar
    {
        public string Nombre { get; set; } = "Infantería Básica";
        public IVelocidad Velocidad { get; set; }
        public IBlindaje Blindaje { get; set; } = new BlindajeNulo();
        public IPotenciaFuego PotenciaFuego { get; set; }
        public double Precio { get; set; } = 250;

        public InfanteriaBasica()
        {
            Velocidad = new VelocidadMedia(6);
            PotenciaFuego = new PotenciaFuegoBaja(7);
        }
    }
}
