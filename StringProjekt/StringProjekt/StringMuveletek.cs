using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace StringProjekt
{
    public static class StringMuveletek
    {
        public static string[] SzavakListaja(string szoveg) => szoveg.Split(" ");

        public static string CimFormazas(string szoveg)
        {
            string output = szoveg;
            output.Split(" ").ToList().ForEach(x => x.Replace(x[0], x[0].ToString().ToUpper().ToCharArray()[0]));
            return output;
        }

        public static string[] SzavakKezdodikEvel(string[] szavak, string keresett) => szavak.ToList().Where(x => x.StartsWith(keresett)).ToArray();

        public static string[] SzavakVegzodikEvel(string[] szavak, string keresett) => szavak.ToList().Where(x => x.EndsWith(keresett)).ToArray();
    }
}