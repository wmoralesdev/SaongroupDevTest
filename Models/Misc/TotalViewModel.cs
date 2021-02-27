using System;

/// <summary>
/// TotalViewModel
/// </summary>
namespace SaongroupDevTest.Models.Misc
{
    public class TotalViewModel
    {
        public DateTime Date { get; set; }

        public DateTime Last_Update { get; set; }

        public int Confirmed { get; set; }

        public int Confirmed_Diff { get; set; }

        public int Deaths { get; set; }

        public int Deaths_Diff { get; set; }

        public int Recovered { get; set; }

        public int Recovered_Diff { get; set; }

        public int Active { get; set; }

        public int Active_Diff { get; set; }

        public float Fatality_Rate { get; set; }
    }
}
