using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenP2.Core.Entities
{
    class Album : BaseEntity
    {
        public Album() {

            Canciones = new List<Cancion>; 
        }
        public string Name { get; set; }
        public string Artista { get; set; }
        public int Precio { get; set; }

        public string Descripcion { get; set; }
        public string Genre { get; set; }
        public int Puntuacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Imagen { get; set; }

        public ICollection<Cancion> Canciones { get; set; }
    }

}
