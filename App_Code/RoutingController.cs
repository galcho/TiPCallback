using System.Web.Http;
using TipCallback.Models;

namespace TipCallback.Controllers
{
    public class RoutingController : ApiController
    {
        [HttpPost]
        public ChangeDirectionResult GetRoutingDirection([FromBody] RerouteChangeRequest metrics)
        {
            // Use either Step or RoutingPercentage. If both returned RoutingPercentage takes precedence
            return new ChangeDirectionResult
            {
                Step = (int)metrics.Metrics["self"].Requests,
                RoutingPercentage = 10
            };
        } 
    }
}