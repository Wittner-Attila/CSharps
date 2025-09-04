# 1.2.2 Számjegyek

## Feladat célja

A feladat számjegyekkel kapcsolatos algoritmusokat megvalósítani. Gyakorolni lehet a számokon végzett számjegy-kezelést, a karakterláncokká való átalakítást, a logikai ellenőrzést, ciklusokat, LINQ használatát, valamint azt, hogyan lehet egy feladatot korábban megoldott metódusok felhasználásával egyszerűsíteni.

---

## Előkészített állományok

A projektben megtalálható:

- `Szamjegyek.cs`: az osztályváz, minden metódus be van készítve, de nem tartalmaznak valós működést
- `Program.cs`: a tesztprogram, amely a metódusokat hívja meg különféle bemenetekkel, és kiírja az eredményt

---

## Feladat

Készítse el a `Szamjegyek` osztály metódusait a `Szamjegyek.cs` fájlban a dokumentációban megfogalmazott cél szerint. A `Program.cs` fájlt nem kell módosítani, ellenőrzésre lehet használni. Minden metódusnak pontosan azt kell csinálnia, amit a dokumentáció ír, de a megvalósításban szabad kezet kap. Ha lehet, építsen a korábban már működő metódusokra.

---

## Metódusfeladatok

### 1. `LegalabbKetjegyu(int szam)`
Állapítsa meg, hogy a szám abszolút értékben legalább kétjegyű-e.

**Példák:**
- 5 → false
- 10 → true
- -47 → true

---

### 2. `ForditottSzam(int szam)`
Adja vissza a szám számjegyeinek megfordítását. Negatív szám esetén az előjelet tartsa meg.

**Példák:**
- 123 → 321
- -45 → -54
- 7 → 7 (egyjegyű szám esetén visszatér magával)

---

### 3. `SzamjegyekOsszege(int szam)`
Számolja ki a szám abszolút értékének számjegyeinek összegét.

**Példák:**
- 123 → 6
- -45 → 9
- 8 → 8 (egyjegyű esetben marad az eredmény)

---

### 4. `PalindromE(int szam)`
Döntse el, hogy a szám palindrom-e (tükörszám), azaz megegyezik-e a fordítottjával.

**Példák:**
- 121 → true
- 1331 → true
- 123 → false
- Egyjegyű szám nem számít palindromnak

*Tipp: használja a `ForditottSzam` és `LegalabbKetjegyu` metódusokat!*

---

### 5. `DigitalisGyok(int szam)`
Számjegyek összegét ismételje addig, amíg egyjegyű számot nem kap.

**Példák:**
- 987 → 9+8+7=24 → 2+4=6 → eredmény: 6

*Tipp: használja a `SzamjegyekOsszege` metódust ismételten!*

---

### 6. `BalrolJobbraKivonas(int szam)`
A szám számjegyeit balról jobbra haladva vonja ki egymásból.

**Példa:**
- 123 → 1 - 2 - 3 = -4

Egyjegyű szám esetén térjen vissza az eredetivel.

---

### 7. `BalrolJobbraKivonasForditva(int szam)`
Fordítsa meg a számot, majd alkalmazza rajta a balról-jobbra kivonást.

*Tipp: használja a `ForditottSzam` és `BalrolJobbraKivonas` metódusokat!*

---

## Fontos
- A metódusokat a `Program.cs` fájl hívja meg, így az eredmények azonnal ellenőrizhetők.
- Törekedjen a kód újrafelhasználhatóságára.
- Használhat LINQ-ot, string műveleteket, ciklusokat stb., de ügyeljen az olvashatóságra!
