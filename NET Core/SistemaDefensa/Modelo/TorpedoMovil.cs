using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class TorpedoMovil : IUnidadMilitar
    {
        public string Nombre { get; set; } = "Torpedero móvil";
        public IVelocidad Velocidad { get; set; }
        public IBlindaje Blindaje { get; set; }
        public IPotenciaFuego PotenciaFuego { get; set; }
        public double Precio { get; set; } = 1350;

        public TorpedoMovil()
        {
            Velocidad = new VelocidadBaja(3);
            Blindaje = new BlindajeBajo(2);
            PotenciaFuego = new PotenciaFuegoAlta(19);
        }
    }
}
