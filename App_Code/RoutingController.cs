using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TipCallback.Models;

namespace TipCallback.Controllers
{
    public class RoutingController : ApiController
    {
        [HttpPost]
        public ChangeDirectionResult GetRoutingDirection([FromBody] RerouteChangeRequest metrics)
        {
            return new ChangeDirectionResult
            {
                Step = metrics.Metrics.Count * 8,
                RoutingPercentage = 10
            };
        }

        [HttpGet]
        public ChangeDirectionResult Get()
        {
            return new ChangeDirectionResult
            {
                RoutingPercentage = 10
            };
        }
    }
}