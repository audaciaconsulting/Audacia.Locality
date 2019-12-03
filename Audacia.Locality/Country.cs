using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Audacia.Locality
{
    public partial class Country
    {
        public Country()
        {
            Flag = new Flag(this);
        }

        public string Code { get; set; }

        public string Name { get; set; }

        public int IsoNumeric { get; set; }

        public string IsoAlpha3 { get; set; }

        public string FipsCode { get; set; }

        public Continent Continent { get; internal set; }

        public string ContinentCode { get; set; }

        public string ContinentName { get; set; }

        public string Capital { get; set; }

        public double AreaSqKm { get; set; }

        public int Population { get; set; }

        public string CurrencyCode { get; set; }

        public ICollection<string> Languages { get; set; } = new List<string>();

        public double North { get; set; }

        public double East { get; set; }

        public double West { get; set; }

        public double South { get; set; }

        public Flag Flag { get; }
    }
}
