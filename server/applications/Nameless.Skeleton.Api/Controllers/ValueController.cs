using Microsoft.AspNetCore.Mvc;

namespace Nameless.Skeleton.Api.Controllers {
    
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ValueController : ControllerBase {

        [HttpGet]
        public IActionResult Get() {
            return Ok(new[] {
                "Value 1", "Value 2"
            });
        }
    }
}
