/// <summary>
/// RegionViewModel
/// </summary>
namespace SaongroupDevTest.Models.Regions
{
    public class RegionViewModel
    {
        public string Iso { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Iso}, {Name}";
        }
    }
}
