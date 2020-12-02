using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamenP2.Models;
using ExamenP2.Core.Interfaces;
using ExamenP2.Core.Enums;

namespace ExamenP2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetailController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }

    [HttpGet]
    [Route("{Albumid}/canciones)"]
    public ActionResult<IEnumerable<Cancion>> Get(int Albumid)
    {
        var serviceResult = _
    }
}
