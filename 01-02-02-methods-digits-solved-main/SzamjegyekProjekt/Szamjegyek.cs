using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamjegyekProjekt
{
    internal class Szamjegyek
    {
        /// <summary>
        /// Eldönti, hogy a szám legalább kétjegyű-e.
        /// </summary>
        /// <param name="szam">A vizsgált szám</param>
        /// <returns>Igaz, ha a szám két vagy több számjegyből áll, egyébként hamis</returns>
        /// <example>LegalabbKetjegyu(5) => false, LegalabbKetjegyu(10) => true</example>
        public static bool LegalabbKetjegyu(int szam)
        {
            return Math.Abs(szam).ToString().Length >= 2;
        }

        /// <summary>
        /// Megfordítja a szám számjegyeit, ha legalább kétjegyű.
        /// </summary>
        /// <param name="szam">A vizsgált szám</param>
        /// <returns>A megfordított szám, vagy eredeti érték, ha egyjegyű</returns>
        /// <example>ForditottSzam(123) => 321, ForditottSzam(-45) => -54, ForditottSzam(7) => 7</example>
        public static int ForditottSzam(int szam)
        {
            if (!LegalabbKetjegyu(szam)) return szam;
            int abs = Math.Abs(szam);
            string forditott = new string(abs.ToString().Reverse().ToArray());
            int eredmeny = int.Parse(forditott);
            return szam < 0 ? -eredmeny : eredmeny;
        }


        /// <summary>
        /// Eldönti, hogy egy szám palindrom-e (tükörszám).
        /// </summary>
        /// <param name="szam">A vizsgált szám</param>
        /// <returns>Igaz, ha a szám palindrom, egyébként hamis</returns>
        /// <example>PalindromE(121) => true, PalindromE(123) => false</example>
        public static int SzamjegyekOsszege(int szam)
        {
            if (!LegalabbKetjegyu(szam)) return szam;
            int abs = Math.Abs(szam);
            return abs.ToString().Select(c => c - '0').Sum();
        }

        /// <summary>
        /// Eldönti, hogy egy szám palindrom-e (tükörszám).
        /// </summary>
        /// <param name="szam">A vizsgált szám</param>
        /// <returns>Igaz, ha a szám palindrom, egyébként hamis</returns>
        /// <example>PalindromE(121) => true, PalindromE(123) => false</example>
        public static bool PalindromE(int szam)
        {
            if (!LegalabbKetjegyu(szam)) return false;
            return Math.Abs(szam) == ForditottSzam(szam);
        }

        /// <summary>
        /// Visszaadja egy szám digitális gyökét.
        /// A számjegyek ismételt összege addig, amíg egyjegyű nem lesz.
        /// </summary>
        /// <param name="szam">A vizsgált szám</param>
        /// <returns>A digitális gyök</returns>
        /// <example>DigitalisGyok(987) => 6, DigitalisGyok(5) => 5</example>
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

        /// <summary>
        /// Balról jobbra haladva kivonja a szám számjegyeit egymásból.
        /// </summary>
        /// <param name="szam">A vizsgált szám</param>
        /// <returns>A balról jobbra kivonás eredménye, vagy az eredeti szám ha egyjegyű</returns>
        /// <example>BalrolJobbraKivonas(123) => -4 (1 - 2 - 3)</example>
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

        /// <summary>
        /// Megfordítja a számot, majd balról jobbra kivonja annak számjegyeit egymásból.
        /// </summary>
        /// <param name="szam">A vizsgált szám</param>
        /// <returns>A fordított szám számjegyeinek balról-jobbra kivonása</returns>
        /// <example>BalrolJobbraKivonasForditva(123) => 0 (3 - 2 - 1)</example>
        public static int BalrolJobbraKivonasForditva(int szam)
        {
            return BalrolJobbraKivonas(ForditottSzam(szam));
        }
    }
}
