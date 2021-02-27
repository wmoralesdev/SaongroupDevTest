using SaongroupDevTest.Models.Regions;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace SaongroupDevTest.Controllers.Region
{
    public static class RegionController 
    {
        // GET: RegionController
        public static async Task<RegionListViewModel> GetRegions()
        {
            RegionListViewModel regions = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings.Get("ApiUrl"));

                var result = await client.GetAsync("regions");

                if (result.IsSuccessStatusCode)
                {
                    try
                    {
                        var data = await result.Content.ReadAsStringAsync();
                        regions = JsonConvert.DeserializeObject<RegionListViewModel>(data);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return regions;
        }
    }
}
