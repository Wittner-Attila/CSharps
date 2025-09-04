using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamjegyekProjekt
{
    internal class Szamjegyek
    {
        public static bool LegalabbKetjegyu(int szam)
        {
            return Math.Abs(szam).ToString().Length >= 2;
        }

        public static int ForditottSzam(int szam)
        {
            if (!LegalabbKetjegyu(szam)) return szam;
            int abs = Math.Abs(szam);
            string forditott = new string(abs.ToString().Reverse().ToArray());
            int eredmeny = int.Parse(forditott);
            return szam < 0 ? -eredmeny : eredmeny;
        }

        public static int SzamjegyekOsszege(int szam)
        {
            if (!LegalabbKetjegyu(szam)) return szam;
            int abs = Math.Abs(szam);
            return abs.ToString().Select(c => c - '0').Sum();
        }

        public static bool PalindromE(int szam)
        {
            if (!LegalabbKetjegyu(szam)) return false;
            return Math.Abs(szam) == ForditottSzam(szam);
        }

        public static int DigitalisGyok(int szam)
        {
            if (!LegalabbKetjegyu(szam)) return szam;
            int eredmeny = Math.Abs(szam);
            while (eredmeny >= 10)
            {
                eredmeny = SzamjegyekOsszege(eredmeny);
            }
            return eredmeny;
        }

        public static int BalrolJobbraKivonas(int szam)
        {
            if (!LegalabbKetjegyu(szam)) return szam;
            int abs = Math.Abs(szam);
            var szamjegyek = abs.ToString().Select(c => c - '0').ToList();
            int eredmeny = szamjegyek[0];
            for (int i = 1; i < szamjegyek.Count; i++)
                eredmeny -= szamjegyek[i];
            return szam < 0 ? -eredmeny : eredmeny;
        }

        public static int BalrolJobbraKivonasForditva(int szam)
        {
            return BalrolJobbraKivonas(ForditottSzam(szam));
        }
    }
}
