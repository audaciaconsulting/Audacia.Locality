using System.Collections;
using System.Collections.Generic;

namespace Audacia.Locality
{
    public partial class Continent : ICollection<Country>
    {
        public ICollection<Country> Countries { get; } = new List<Country>();

        public Continent(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public string Name { get; }

        public string Code { get; }

        public IEnumerator<Country> GetEnumerator() => Countries.GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable) Countries).GetEnumerator();

        public void Add(Country item) => Countries.Add(item);

        public void Clear() => Countries.Clear();

        public bool Contains(Country item) => Countries.Contains(item);

        public void CopyTo(Country[] array, int arrayIndex) => Countries.CopyTo(array, arrayIndex);

        public bool Remove(Country item) => Countries.Remove(item);

        public int Count => Countries.Count;

        public bool IsReadOnly => Countries.IsReadOnly;
    }
}
