This is sample site extension for Azure websites Testing In Production TiP ramp up scenario.

To play with it install it on your Azure web site http://azure.microsoft.com/blog/2014/06/20/azure-web-sites-extensions/

To change TiP callback behaviour modify App_Code\RoutingController.cs
```c#
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
```