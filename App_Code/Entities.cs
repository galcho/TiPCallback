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


    [DataContract]
    public class ChangeDirectionResult
    {
        [DataMember(Name = "step")]
        public int? Step { get; set; }

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