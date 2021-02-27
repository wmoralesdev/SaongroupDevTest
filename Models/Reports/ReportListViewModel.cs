using System;
using System.Collections.Generic;
using SaongroupDevTest.Models.Regions;

/// <summary>
/// ReportListViewModel
/// Contains List of RegionViewModel
/// </summary>
namespace SaongroupDevTest.Models.Reports
{
    public class ReportListViewModel
    {
        public DateTime Date { get; set; }

        public int Confirmed { get; set; }

        public int Deaths { get; set; }

        public int Recovered { get; set; }

        public int Confirmed_Diff { get; set; }

        public int Deaths_Diff { get; set; }

        public DateTime Last_Update { get; set; }

        public int Active { get; set; }

        public int Active_Diff { get; set; }

        public float Fatality_Rate { get; set; }

        public List<RegionViewModel> Region { get; set; }
    }
}
