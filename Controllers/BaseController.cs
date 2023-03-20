using Microsoft.AspNetCore.Mvc;

namespace COMP306_MelVincent_Lab3.Controllers
{
    [ApiController]
    public abstract class BaseController<T> : Controller
    {
        protected readonly ILogger<T> _logger;
        
        public BaseController(ILogger<T> logger)
        {
            _logger = logger;
        }
    }
}
