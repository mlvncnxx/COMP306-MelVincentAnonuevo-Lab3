using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace COMP306_MelVincent_Lab3.Controllers
{
    [Route("health")]
    public class HealthController : BaseController<HealthController>
    {
        public HealthController(ILogger<HealthController> logger) : base(logger)
        {
        }

        [HttpGet]
        public IActionResult Health()
        {
            return Ok("healthy");
        }
    }
}
