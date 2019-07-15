using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Audacia.Locality
{
    public static class World
    {
        public static IEnumerable<Continent> Continents { get; } = typeof(Continent)
            .GetTypeInfo().DeclaredProperties
            .Where(p => p.PropertyType == typeof(Continent))
            .Select(p => (Continent) p.GetValue(null));

        public static IEnumerable<Country> Countries { get; } = typeof(Country)
            .GetTypeInfo().DeclaredProperties
            .Where(p => p.PropertyType == typeof(Country))
            .Select(p => (Country) p.GetValue(null));
    }
}