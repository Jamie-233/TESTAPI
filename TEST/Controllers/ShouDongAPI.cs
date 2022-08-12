using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TEST.Controllers
{
    [Route("api/shoudongapi")]
    public class ShouDongAPIController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get() => new String[] { "value1", "value2" };
    }
}

