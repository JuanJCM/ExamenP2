using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExamenP2.Models;
namespace ExamenP2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private static readonly Models.Album[] Albums = new[]
        {
            new Models.Album
            {
                Name = "All Out",
                Artista = "KDA",
                Precio = 10,
                Genre = "Kpop",
                Puntuacion  = 4,
                Fecha = DateTime.Today,
                Imagen = " ",
                Cancion = 
                {
                   new Cancion
                {
                    Nombre = "The Baddest",
                    Artista = "KDA",
                    Duracion = 5,
                    Popularidad = 4,
                    Precio = 1
                },
                new Cancion
                {

                } 
                }
            }
        };

        private readonly ILogger<AlbumController> _logger;

        public AlbumController(ILogger<AlbumController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Models.Album> Get()
        {
            return Albums;
        } 

        [HttpGet]
        public Models.Album Get(int albumid)
        {
            return null;
        }
    }
}
