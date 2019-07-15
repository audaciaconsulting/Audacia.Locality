using System.IO;
using System.Reflection;

namespace Audacia.Locality
{
    public class Flag
    {
        private readonly Assembly _assembly = typeof (Flag).GetTypeInfo().Assembly;
        private readonly Country _country;
        private const string ResourcePrefix = "Audacia.Locality.Flags.";

        public Flag(Country country)
        {
            _country = country;
        }

        private byte[] Stream(string type) => GetBytes(_assembly.GetManifestResourceStream($"{ResourcePrefix}{type}.{_country.Code.ToLower()}.png"));

        public byte[] Small => Stream(nameof (Small));

        public byte[] Medium => Stream(nameof (Medium));

        public byte[] Large => Stream(nameof (Large));

        private byte[] GetBytes(Stream stream)
        {
            var buffer = new byte[16384];
            using (var memoryStream = new MemoryStream())
            {
                int count;
                while ((count = stream.Read(buffer, 0, buffer.Length)) > 0)
                    memoryStream.Write(buffer, 0, count);
                return memoryStream.ToArray();
            }
        }
    }
}