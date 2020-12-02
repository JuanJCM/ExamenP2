using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenP2.Models
{
    public class Album
    {
        public string Name { get; set; }
        public string Artista { get; set; }
        public int Precio { get; set; }

        public string Genre { get; set; }
        public int Puntuacion { get; set; }
        public  DateTime Fecha { get; set; }
        public string Imagen { get; set; }
        public IEnumerable<Cancion> Cancion { get; set; }
    }
}
