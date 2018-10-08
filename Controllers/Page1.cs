using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIClient;

namespace AutomatedTrader.Controllers
{
    [Route("api/[controller]")]
    public class Page1 : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
           
            
            
            var repos = WebClient.ProcessRepositories().Result;
            var btc = WebClient.TestGetParams().Result;
            return new JsonResult(new {data = 1, repos, btc});
        }   
    }
}