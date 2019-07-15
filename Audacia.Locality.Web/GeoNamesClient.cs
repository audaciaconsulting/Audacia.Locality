using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Audacia.Locality.Web
{
    public class GeoNamesClient
    {
        private HttpClient _http = new HttpClient { BaseAddress = new Uri("http://api.geonames.org") };

        public async Task<Country[]> Countries()
        {
            var response = await _http.GetStringAsync($"countryInfo?username={Credentials.Username}&type=json");
            var json = JsonConvert.DeserializeObject<JObject>(response);
            return json["geonames"]
                .Select(token => new Country
                {
                    AreaSqKm = token.Value<double>("areaInSqKm"),
                    Capital = token.Value<string>("capital"),
                    Code = token.Value<string>("countryCode"),
                    ContinentCode = token.Value<string>("continent"),
                    ContinentName = token.Value<string>("continentName"),
                    CurrencyCode = token.Value<string>("currencyCode"),
                    North = token.Value<double>("north"),
                    East = token.Value<double>("east"),
                    South = token.Value<double>("south"),
                    West = token.Value<double>("west"),
                    FipsCode = token.Value<string>("fipsCode"),
                    IsoAlpha3 = token.Value<string>("isoAlpha3"),
                    IsoNumeric = token.Value<int>("isoNumeric"),
                    Languages = token.Value<string>("languages").Split(','),
                    Name = token.Value<string>("countryName"),
                    Population = token.Value<int>("population")
                }).ToArray();
        }
    }
}
