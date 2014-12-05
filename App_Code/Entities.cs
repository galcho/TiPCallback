using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TipCallback.Models
{
    [DataContract]
    public class MetricsWrapper
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember]
        public object Activity { get; set; }
    }

    [DataContract]
    public class Metrics
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        public SiteHttpActivity Activity { get; set; }
    }


    /// <summary>
    /// Return information how to change TiP ramp up percentage.
    /// Use either Step or RoutingPercentage. If both returned RoutingPercentage takes precedence
    /// Either way MinRoutingPercentage and MaxRoutingPercentage set in API rule are in force
    /// </summary>
    [DataContract]
    public class ChangeDirectionResult
    {
        /// <summary>
        /// Step to change the Routing percentage. Positive number will increase it routing.
        /// Negative will decrease it.
        /// </summary>
        [DataMember(Name = "step")]
        public int? Step { get; set; }

        /// <summary>
        /// Hard routing percentage to set regardless of step.
        /// </summary>
        [DataMember(Name = "routingPercentage")]
        public int? RoutingPercentage { get; set; }
    }

    [DataContract]
    public class RerouteChangeRequest
    {
        [DataMember]
        public Dictionary<string, SiteHttpActivity> Metrics { get; set; }
    }

    [DataContract]
    public class SiteHttpActivity
    {
        [DataMember]
        public long Requests { get; set; }
    }
}