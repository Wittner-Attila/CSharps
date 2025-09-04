using SzamjegyekProjekt;

static void Teszt(string leiras, int bemenet, Func<int, int> muvelet)
{
    Console.WriteLine($"{leiras} ({bemenet}): {muvelet(bemenet)}");
}

static void TesztBool(string leiras, int bemenet, Func<int, bool> vizsgalat)
{
    Console.WriteLine($"{leiras} ({bemenet}): {(vizsgalat(bemenet) ? "IGEN" : "NEM")}");
}

Console.WriteLine("=== Szamkezeles tesztek ===\n");

// ForditottSzam tesztek
Teszt("ForditottSzam", 123, Szamjegyek.ForditottSzam);
Teszt("ForditottSzam", -45, Szamjegyek.ForditottSzam);
Teszt("ForditottSzam", 7, Szamjegyek.ForditottSzam);

Console.WriteLine();

// SzamjegyekOsszege tesztek
Teszt("SzamjegyekOsszege", 123, Szamjegyek.SzamjegyekOsszege);
Teszt("SzamjegyekOsszege", -45, Szamjegyek.SzamjegyekOsszege);
Teszt("SzamjegyekOsszege", 8, Szamjegyek.SzamjegyekOsszege);

Console.WriteLine();

// Palindrom vizsgálat
TesztBool("PalindromE", 121, Szamjegyek.PalindromE);
TesztBool("PalindromE", 123, Szamjegyek.PalindromE);
TesztBool("PalindromE", 7, Szamjegyek.PalindromE);

Console.WriteLine();

// DigitalisGyok tesztek
Teszt("DigitalisGyok", 987, Szamjegyek.DigitalisGyok);
Teszt("DigitalisGyok", 5, Szamjegyek.DigitalisGyok);
Teszt("DigitalisGyok", 9999, Szamjegyek.DigitalisGyok);

Console.WriteLine();

// BalrolJobbraKivonas tesztek
Teszt("BalrolJobbraKivonas", 123, Szamjegyek.BalrolJobbraKivonas);
Teszt("BalrolJobbraKivonas", 8, Szamjegyek.BalrolJobbraKivonas);

Console.WriteLine();

// BalrolJobbraKivonasForditva tesztek
Teszt("BalrolJobbraKivonasForditva", 123, Szamjegyek.BalrolJobbraKivonasForditva);
Teszt("BalrolJobbraKivonasForditva", 7, Szamjegyek.BalrolJobbraKivonasForditva);
