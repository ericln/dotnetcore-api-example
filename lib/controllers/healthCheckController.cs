using System.Collections.Generic;
using HWAPP.Services;
using Microsoft.AspNetCore.Mvc;

namespace HWAPP.Controllers
{
    [Route("api/v1/status")]
    public class HealthCheckContoller: Controller
    {
        [HttpGet]
        public dynamic Get() 
        {
            var result = new {
                status= "ok"
            };

            return result;
        }
    }   
}