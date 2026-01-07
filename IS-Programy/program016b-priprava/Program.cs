using System.Globalization;

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

    // VSTUP N
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
    }

    // DOLNÍ MEZ 
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
    }

    // HORNÍ MEZ 
    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        if (upperBound < lowerBound)
            Console.Write($"Horní mez musí být větší než dolní ({lowerBound}). Znovu: ");
        else
            Console.Write("Nezadali jste celé číslo. Znovu: ");
    }

    Console.WriteLine("\n======================================================");
    Console.WriteLine($"Počet: {n}; Dolní: {lowerBound}; Horní: {upperBound}");
    Console.WriteLine("======================================================");

    // DEKLARACE POLE
    int[] nums = new int[n];
    Random myRandNumb = new Random();

    Console.WriteLine("\nPseudonáhodná čísla: ");

    // OPRAVA 1: Index začíná od 0, ne od 1!
    for (int i = 0; i < n; i++) 
    {
        nums[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", nums[i]);
    }
    Console.WriteLine();

    // MIN A MAX
    int max = nums[0];
    int min = nums[0];

    // OPRAVA 2: I tady musíme projít celé pole (od 1 dál je ok, protože 0 už máme v max/min)
    for (int i = 1; i < n; i++)
    {
        if (nums[i] > max) max = nums[i];
        if (nums[i] < min) min = nums[i];
    }

    Console.WriteLine("\n======================================================");
    Console.Write($"Maximum je {max} a jeho pozice: ");
    for (int i = 0; i < n; i++) // OPRAVA: Zase musíme projít od 0
    {
        if (nums[i] == max) Console.Write($"{i+1}; ");
    }

    Console.WriteLine("\n======================================================");
    Console.Write($"Minimum je {min} a jeho pozice: ");
    for (int i = 0; i < n; i++) // OPRAVA: Zase musíme projít od 0
    {
        if (nums[i] == min) Console.Write($"{i+1}; ");
    }

    // SORTING - INSERTION (SESTUPNĚ!)
    for (int i = 1; i < n; i++)
    {
        int cislo = nums[i];
        int j = i - 1;

        // OPRAVA 3: Změna znaménka na '<' pro sestupné řazení (9, 8, 7...)
        // OPRAVA 4: Správný posun v poli
        while (j >= 0 && nums[j] < cislo) 
        {
            nums[j + 1] = nums[j]; // Posouváme doprava
            j--;
        }
        nums[j + 1] = cislo; // Vkládáme na uvolněné místo
    }

    Console.WriteLine("\n\n======================================================");
    Console.WriteLine("Seřazená čísla (Insertion Sort - Sestupně): ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", nums[i]);
    }

    // 2., 3., 4. NEJVĚTŠÍ ČÍSLO
    int uniqueCount = 0;
    int lastValue = int.MinValue; 
    int second = 0, third = 0, fourth = 0;

    for (int i = 0; i < n; i++)
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

    Console.WriteLine("\n\n======================================================");
    Console.WriteLine("Druhé největší: " + second);
    Console.WriteLine("Třetí největší: " + third);
    Console.WriteLine("Čtvrté největší: " + fourth);

    // MEDIÁN
    int median; // Lepší double, kdyby to vyšlo s desetinou (u sudých)
    if (n % 2 == 1)
        median = nums[n / 2]; // OPRAVA 5: Jedno rovnítko!
    else
        median = (nums[n / 2 - 1] + nums[n / 2]) / 2; // OPRAVA 6: Závorky!

    Console.WriteLine("\n======================================================");
    Console.WriteLine($"Medián: {median}");

    // BINÁRNÍ SOUSTAVA
    string bin = "";
    int x = fourth;
    if (x == 0) bin = "0";
    while (x > 0)
    {
        bin = (x % 2) + bin;
        x /= 2;
    }

    Console.WriteLine("\n================================================");
    Console.WriteLine($"Čtvrté největší v binární: {fourth}(10) = {bin}(2)");

    // KRESLENÍ OBRAZCE
    Console.WriteLine("\n\n======================================================");
    int height = median; // Musíme přetypovat zpět na int pro cyklus
    int width = third;

    Console.WriteLine($"Obrazec: Výška {height}, Šířka {width}");
    Console.WriteLine();

    int part = height / 3;
    int smallWidth;
    int indent;

    if (width % 2 == 0)
    {
        smallWidth = 2;
        indent = (width - 2) / 2;
    }
    else
    {
        smallWidth = 3;
        indent = (width - 3) / 2;
    }

    for (int i = 0; i < height; i++)
    {
        // OPRAVA 7: Rozdělení na TŘI části (if - else if - else)
        
        // HORNÍ ČÁST
        if (i < part)
        {
            for (int s = 0; s < indent; s++) Console.Write("  ");
            for (int j = 0; j < smallWidth; j++) Console.Write("* ");
        }
        // PROSTŘEDNÍ ČÁST (tohle chybělo)
        else if (i < height - part)
        {
            for (int j = 0; j < width; j++) Console.Write("* ");
        }
        // DOLNÍ ČÁST
        else
        {
            for (int s = 0; s < indent; s++) Console.Write("  ");
            for (int j = 0; j < smallWidth; j++) Console.Write("* ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("\nPro opakování stiskněte 'a', jinak Enter.");
    again = Console.ReadLine();
}