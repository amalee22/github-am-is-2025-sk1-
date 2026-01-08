string again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
    Console.WriteLine("*******************************************");
    Console.WriteLine("************* Amálie Musilová *************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();

    // ================= VSTUP HODNOT =================
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n < 5) // Ošetření, aby n bylo alespoň 5 pro statistiku
    {
        Console.Write("Chyba. Zadejte celé číslo (alespoň 5): ");
    }

    // DOLNÍ MEZ
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    // HORNÍ MEZ
    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        if (upperBound < lowerBound)
            Console.Write($"Horní mez musí být větší než dolní ({lowerBound}). Zadejte znovu: ");
        else
            Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine("\n======================================================");
    Console.WriteLine($"Zadáno: Počet: {n}; Rozsah: <{lowerBound}, {upperBound}>");
    Console.WriteLine("======================================================");

    // ================= GENERIVÁNÍ ČÍSEL =================
    int[] nums = new int[n];
    Random myRandNumb = new Random();

    Console.WriteLine("\nPseudonáhodná čísla (původní pořadí):");
    for (int i = 0; i < n; i++)
    {
        nums[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", nums[i]);
    }
    Console.WriteLine();

    // ================= MIN A MAX + POZICE =================
    // Hledáme ještě před seřazením, abychom měli původní indexy
    int max = nums[0];
    int min = nums[0];

    for (int i = 0; i < n; i++)
    {
        if (nums[i] > max) max = nums[i];
        if (nums[i] < min) min = nums[i];
    }

    Console.WriteLine("\n================== MIN / MAX =========================");
    
    // Výpis Maxima a jeho pozic
    Console.Write($"MAXIMUM je {max} a leží na pozici: ");
    for (int i = 0; i < n; i++)
    {
        if (nums[i] == max) Console.Write($"{i + 1}; ");
    }
    Console.WriteLine();

    // Výpis Minima a jeho pozic
    Console.Write($"MINIMUM je {min} a leží na pozici: ");
    for (int i = 0; i < n; i++)
    {
        if (nums[i] == min) Console.Write($"{i + 1}; ");
    }
    Console.WriteLine();

    // ================= INSERTION SORT =================
    for (int i = 1; i < n; i++)
    {
        int cislo = nums[i];
        int j = i - 1;

        while (j >= 0 && nums[j] > cislo)
        {
            nums[j + 1] = nums[j];
            j--;
        }
        nums[j + 1] = cislo;
    }

    Console.WriteLine("\n================== SEŘAZENÁ ČÍSLA ====================");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", nums[i]);
    }
    Console.WriteLine();

    // ================= 2., 3., 4. NEJVĚTŠÍ ČÍSLO =================
    // POZOR: Pole je seřazené VZESTUPNĚ (malá -> velká).
    // Pro největší čísla musíme jít od konce pole (od n-1 směrem k 0).
    
    int uniqueCount = 0;
    int lastValue = int.MaxValue; // Inicializace na hodnotu, která tam asi nebude
    int second = 0, third = 0, fourth = 0;

    for (int i = n - 1; i >= 0; i--) // Jdeme odzadu!
    {
        if (nums[i] != lastValue)
        {
            uniqueCount++;
            lastValue = nums[i];

            if (uniqueCount == 2) second = nums[i];
            if (uniqueCount == 3) third = nums[i];
            if (uniqueCount == 4) fourth = nums[i];
        }
    }

    Console.WriteLine("\n================== UNIKÁTNÍ HODNOTY ==================");
    Console.WriteLine("2. největší: " + (uniqueCount >= 2 ? second.ToString() : "Není"));
    Console.WriteLine("3. největší: " + (uniqueCount >= 3 ? third.ToString() : "Není"));
    Console.WriteLine("4. největší: " + (uniqueCount >= 4 ? fourth.ToString() : "Není"));

    // ================= MEDIÁN =================
    double median; // Medián může být i desrinné číslo
    if (n % 2 == 1)
        median = nums[n / 2];
    else
        median = (nums[n / 2 - 1] + nums[n / 2]) / 2.0; // Děleno 2.0 pro desetinný výsledek

    Console.WriteLine($"Medián:      {median}");

    // ================= BINÁRNÍ ZÁPIS (4. největšího) =================
    if (uniqueCount >= 4)
    {
        string bin = "";
        int x = Math.Abs(fourth); // Pro převod použijeme absolutní hodnotu
        string sign = fourth < 0 ? "-" : ""; // Znaménko vyřešíme zvlášť

        if (x == 0) bin = "0";

        while (x > 0)
        {
            bin = (x % 2) + bin;
            x /= 2;
        }

        Console.WriteLine("\n================== BINÁRNÍ SOUSTAVA ==================");
        Console.WriteLine($"4. největší ({fourth}) binárně: {sign}{bin}");
    }

    // ================= VYKRESLOVÁNÍ OBRAZCE =================
    Console.WriteLine("\n================== OBRAZEC (Kosočtverec) =============");
    
    // Výška se bere z mediánu, šířka z 3. největšího (podle zadání)
    // Používám Math.Abs (absolutní hodnotu), aby program nespadl u záporných čísel
    // A Math.Max(3, ...), aby byl obrazec alespoň trochu vidět
    int height = Math.Max(3, Math.Abs((int)median)); 
    
    Console.WriteLine($"Vykreslení pro výšku {height} (dle mediánu):");
    Console.WriteLine();

    // Vrchní část
    for (int i = 0; i < height; i++)
    {
        int spaces = height - i - 1;
        int stars = 2 * i + 1;

        Console.Write(new string(' ', spaces * 2)); // Odsazení zleva

        for (int j = 0; j < stars; j++)
        {
            // Vykreslíme hvězdu jen na začátku a na konci řádku (dutý tvar)
            if (j == 0 || j == stars - 1)
                Console.Write("* ");
            else
                Console.Write("  ");
        }
        Console.WriteLine();
    }

    // Spodní část (zrcadlově obrácená vrchní část bez nejširšího řádku)
    for (int i = height - 2; i >= 0; i--)
    {
        int spaces = height - i - 1;
        int stars = 2 * i + 1;

        Console.Write(new string(' ', spaces * 2));

        for (int j = 0; j < stars; j++)
        {
            if (j == 0 || j == stars - 1)
                Console.Write("* ");
            else
                Console.Write("  ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("\n======================================================");
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
    again = Console.ReadLine() ?? "";
}