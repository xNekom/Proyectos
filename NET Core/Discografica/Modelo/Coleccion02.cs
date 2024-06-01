using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica.Modelo
{
    public class Coleccion02
    {
        private List<ICancion> canciones;
        private List<Anuncio> anuncios;
        private IValidador validador;

        public Coleccion02(IValidador validador)
        {
            this.canciones = new List<ICancion>();
            this.anuncios = new List<Anuncio>();
            this.validador = validador;
        }

        public void AgregarCancion(ICancion cancion)
        {
            if (validador.EsValida(cancion as Cancion))
            {
                canciones.Add(cancion);
            }
        }

        public void AgregarAnuncio(Anuncio anuncio)
        {
            anuncios.Add(anuncio);
        }

        public double ObtenerDuracionTotal()
        {
            double duracionTotal = 0;
            foreach (ICancion cancion in canciones)
            {
                duracionTotal += cancion.Duracion;
            }
            return duracionTotal;
        }

        public int ObtenerCantidadCanciones()
        {
            return canciones.Count;
        }

        public double ObtenerIngresos()
        {
            double ingresos = 0;
            foreach (Anuncio anuncio in anuncios)
            {
                ingresos += anuncio.Costo;
            }
            return ingresos;
        }
    }
}
