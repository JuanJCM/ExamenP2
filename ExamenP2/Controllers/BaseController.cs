using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamenP2.Core;
using ExamenP2.Core.Enums;

namespace ExamenP2.Controllers
{
    public class BaseController : ControllerBase
    {

        public ActionResult GetResult<T>(ServiceResult<T> serviceResult)
        {
            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);
            return Ok();
        }
    }
}
