string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************************");
    Console.WriteLine("************* Zápočtový test IS ***************");
    Console.WriteLine("************ Datum: 15. 1. 2026 ***************");
    Console.WriteLine("********** Autor: Amálie Musilová *************");
    Console.WriteLine("***********************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel: ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        Console.Write("Zadejte kladné celé číslo: ");

    Console.Write("Zadejte dolní mez: ");
    int dm;
    while (!int.TryParse(Console.ReadLine(), out dm))
        Console.Write("Zadejte celé číslo: ");

    Console.Write("Zadejte horní mez: ");
    int hm;
    while (!int.TryParse(Console.ReadLine(), out hm) || hm < dm)
        Console.Write("Zadejte celé číslo větší nebo rovné dolní mezi: ");

    int[] a = new int[n];
    Random rnd = new Random();

    Console.WriteLine("\nPseudonáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        a[i] = rnd.Next(dm, hm + 1);
        Console.Write(a[i] + ", ");
    }

    // ŘAZENÍ – Selection sort (sestupně)
    for (int i = 0; i < n; i++)
    {
        int maxIdx = i;
        for (int j = i + 1; j < n; j++)
            if (a[j] > a[maxIdx]) maxIdx = j;

        int tmp = a[i];
        a[i] = a[maxIdx];
        a[maxIdx] = tmp;
    }

    Console.WriteLine("\n\nSeřazené pole:");
    for (int i = 0; i < n; i++)
        Console.Write(a[i] + ", ");

    // maximum, minimum, součet
    int max = a[0], min = a[0], sum = 0;
    for (int i = 0; i < n; i++)
    {
        if (a[i] < min) min = a[i];
        sum += a[i];
    }

    // 2., 3. a 4. největší číslo (unikátní hodnoty)
    int count = 0, last = int.MinValue;
    int second = 0, third = 0, fourth = 0;

    for (int i = 0; i < n; i++)
        if (a[i] != last)
        {
            count++;
            last = a[i];
            if (count == 2) second = a[i];
            if (count == 3) third = a[i];
            if (count == 4) fourth = a[i];
        }

    Console.WriteLine("\n\nMaximum: " + max);
    if (count >= 2) Console.WriteLine("Druhé největší číslo: " + second);
    if (count >= 3) Console.WriteLine("Třetí největší číslo: " + third);
    if (count >= 4) Console.WriteLine("Čtvrté největší číslo: " + fourth);

    // součet cifer maxima
    int tmpMax = max, sumDigits = 0;
    while (tmpMax > 0)
    {
        sumDigits += tmpMax % 10;
        tmpMax /= 10;
    }
    Console.WriteLine("Součet cifer u maxima: " + sumDigits);

    // medián
    int median;
    if (n % 2 == 1)
        median = a[n / 2];
    else
        median = (a[n / 2 - 1] + a[n / 2]) / 2;

    Console.WriteLine("Medián: " + median);
    Console.WriteLine("Součet: " + sum);

    int avgInt = sum / n;
    int avgRem = sum % n;
    Console.WriteLine($"Průměr: celá část = {avgInt}, zbytek = {avgRem}");

    // NSD a NSN (maximum a třetí největší číslo)
    if (count >= 3)
    {
        int x = max, y = third;
        while (y != 0)
        {
            int r = x % y;
            x = y;
            y = r;
        }

        int nsd = x;
        int nsn = (max * third) / nsd;

        Console.WriteLine($"NSD({max}, {third}) = {nsd}");
        Console.WriteLine($"NSN({max}, {third}) = {nsn}");
    }

    // VYKRESLENÍ OBRAZCE – tvar písmene S
    if (fourth > 0 && avgInt > 0)
    {
        Console.WriteLine("\nObrazec:");

        bool vlevo = true;   // strana spojovacího znaku
        char znak = '*';     // počáteční znak
        int pocetRadku = 0;

        while (pocetRadku < fourth)
        {
            // plná vodorovná řada
            for (int j = 0; j < avgInt; j++)
                Console.Write(znak + " ");
            Console.WriteLine();
            pocetRadku++;

            if (pocetRadku >= fourth) break;

            // spojovací svislý znak
            if (vlevo)
            {
                Console.WriteLine(znak);
            }
            else
            {
                for (int j = 0; j < avgInt - 1; j++)
                    Console.Write("  ");
                Console.WriteLine(znak);
            }
            pocetRadku++;

            // změna znaku a strany
            if (znak == '*') {
                znak = '#';
            }
            else {
                znak = '*';
            }
            vlevo = !vlevo;
        }
    }
    else
    {
        Console.WriteLine("\nObrazec nelze vykreslit.");
    }

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nPro opakování programu stiskněte klávesu a.");
    Console.ResetColor();
    again = Console.ReadLine();
}