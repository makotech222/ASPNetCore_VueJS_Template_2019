using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VueWebApp.Controllers
{
    [Route("api/[controller]")]
    public class IndexController : Controller
    {
        [HttpGet("[action]")]
        public JsonResult Get()
        {
            return Json("Hello api request");
        }
    }
}
