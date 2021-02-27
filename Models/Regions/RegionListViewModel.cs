using Newtonsoft.Json;
using System.Collections.Generic;

namespace SaongroupDevTest.Models.Regions
{
    public class RegionListViewModel
    {
        [JsonProperty(PropertyName = "data")]
        public List<RegionViewModel> regions { get; set; }
    }
}
