using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenP2.Core.Entities
{
    class Cancion : BaseEntity
    {
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public int Duracion { get; set; }
        public int Popularidad { get; set; }

        public int Precio { get; set; }
    }
}
