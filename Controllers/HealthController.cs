using Microsoft.AspNetCore.Mvc;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public ActionResult<object> Get()
        {
            var response = new
            {
                status = "I'm healthy! Churr My Brother!! Ka pai!"
            };
            
            return Ok(response);
        }
    }
}