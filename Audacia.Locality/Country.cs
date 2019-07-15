using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Audacia.Locality.Web")]
[assembly: InternalsVisibleTo("Audacia.Locality.Tests")]

namespace Audacia.Locality
{
    public partial class Country
    {
        public Country()
        {
            Flag = new Flag(this);
        }

        public string Code { get; internal set; }

        public string Name { get; internal set; }

        public int IsoNumeric { get; internal set; }

        public string IsoAlpha3 { get; internal set; }

        public string FipsCode { get; internal set; }

        public Continent Continent { get; internal set; }

        public string ContinentCode { get; internal set; }

        public string ContinentName { get; internal set; }

        public string Capital { get; internal set; }

        public double AreaSqKm { get; internal set; }

        public int Population { get; internal set; }

        public string CurrencyCode { get; internal set; }

        public ICollection<string> Languages { get; internal set; } = new List<string>();

        public double North { get; internal set; }

        public double East { get; internal set; }

        public double West { get; internal set; }

        public double South { get; internal set; }

        public Flag Flag { get; }
    }
}
