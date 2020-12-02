using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamenP2.Core.Interfaces;
using ExamenP2.Models;
using ExamenP2.Core.Enums;
namespace ExamenP2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomePageController : Controller
    {
        private readonly IAlbumService _albumServices;   

        public HomePageController(IAlbumService albumService)
        {
            _albumServices = albumService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Album>> Get()
        {
            var serviceResult = _albumServices.GetAlbums();
            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);

            return Ok(serviceResult.Result.Select(x => new Album 
            {
                Name = x.Name,
                Artista = x.Artista,
                Precio = x.Precio

            }));
        }

    }
}
