using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica.Modelo
{
    public class Album : IAlbum
    {
        private List<ICancion> canciones;

        public Album(string titulo)
        {
            canciones = new List<ICancion>();
        }

        public void AgregarCancion(ICancion cancion)
        {
            canciones.Add(cancion);
        }

        public List<ICancion> Canciones
        {
            get { return canciones; }
        }
    }
}
