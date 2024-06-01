using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Modelo
{
    public class CanionAntiaereo : IUnidadMilitar
    {
        public string Nombre { get; set; } = "Cañon Antiaéreo";
        public IVelocidad Velocidad { get; set; } = new VelocidadBaja(1);
        public IBlindaje Blindaje { get; set; } = new BlindajeNulo();
        public IPotenciaFuego PotenciaFuego { get; set; }
        public double Precio { get; set; } = 1100;

        public CanionAntiaereo()
        {
            PotenciaFuego = new PotenciaFuegoAlta(22);
        }
    }
}
