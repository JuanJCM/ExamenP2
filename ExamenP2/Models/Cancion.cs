using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenP2.Models
{
    public class Cancion
    {
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public int Duracion { get; set; }
        public  int Popularidad { get; set; }

        public int Precio { get; set; }
    }
}
