using System;

/// <summary>
/// AdditionCityViewModel
/// </summary>
namespace SaongroupDevTest.Models.Cities
{
    public class AdditionCityViewModel
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Fips { get; set; }

        public string Lat { get; set; }

        public string Long { get; set; }

        public int Confirmed { get; set; }

        public int Deaths { get; set; }

        public int Confirmed_Diff { get; set; }

        public int Deaths_Diff { get; set; }

        public DateTime Last_Update { get; set; }
    }
}
