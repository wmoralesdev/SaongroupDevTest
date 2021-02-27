using SaongroupDevTest.Models.Cities;
using System.Collections.Generic;

/// <summary>
/// AdditionRegionViewModel
/// </summary>
namespace SaongroupDevTest.Models.Regions
{
    public class AdditionRegionViewModel
    {
        public string Iso { get; set; }

        public string Name { get; set; }

        public string Province { get; set; }

        public string Lat { get; set; }

        public string Long { get; set; }

        public List<AdditionCityViewModel> Cities { get; set; }
    }
}
