# Audacia.Locality

### A type-safe C# library for working with geographical country data, provided by the [Geonames](http://www/geonames.org) API.

[![Build Status](https://dev.azure.com/audacia/Audacia/_apis/build/status/Audacia.Locality?branchName=master)](https://dev.azure.com/audacia/Audacia/_build/latest?definitionId=273&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Audacia.Locality.svg)](https://www.nuget.org/packages/Audacia.Locality)

# Usage

Continents can be accessed as a static collection on the `World` class, and similarly, so can all the countries of the world. continents and countries can also be accessed using enum-like static members on their respective classes.

An example of using LINQ to find the country with the highest population:

```c#

World.Countries.OrderBy(c => c.Population).First()

```

Another example of finding all countries in Europe that are bigger than sweden:

```c#

Continent.Europe.Countries.Where(c => c.AreaSqKm > Country.Sweden.AreaSqKm)

```

The `Country` class contains various metadata about the country such as its location, size, population, and its official flag (provided as a byte array).

# Development

The library uses two `t4` template files to generate all its data, using the Geonames API. In order to successfully build the solution, a valid Geonames username must be provided in the `Credentials` class in `Audacia.Locality.Web`.

