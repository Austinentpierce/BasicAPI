using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public string SayHello(string who)
        {
            string whoOrWorld;

            if (who == null)
            {
                whoOrWorld = "World";
            }
            else
            {
                whoOrWorld = who;
            }

            {
                return $"Hello, {who} {DateTime.Now}.";
            }
        }
    }
}