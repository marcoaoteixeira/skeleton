using Microsoft.AspNetCore.Mvc;

namespace Nameless.Skeleton.Api.Areas.Auth.Controllers {

    [ApiController]
    [ApiVersion("1")]
    [Area("auth")]
    [Route("api/v{version:apiVersion}/[area]/[controller]")]
    public class ValueController : ControllerBase {

        [HttpGet]
        public IActionResult Get() {
            var myAreaName = string.Empty;
            object areaObj = string.Empty;
            if (RouteData.Values.TryGetValue("area", out areaObj!)) {
                myAreaName = areaObj.ToString();
            }

            return Ok(new[] {
                "Auth 1", "Auth 2", myAreaName
            });
        }
    }
}
