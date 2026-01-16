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

    // Vstup hodnoty do programu
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
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
        {
            Console.Write($"Horní mez musí být větší než dolní mez ({lowerBound}). Zadejte horní mez znovu: ");
        }
        else
        {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
        }
    }

    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine($"Počet generovaných čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("======================================================");

    // DEKLARACE POLE
    int[] nums = new int[n];

    // Generování čísel
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine("Pseudonáhodná čísla:");

    for (int i = 0; i < n; i++)
    {
        nums[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0};  ", nums[i]);
    }

    Console.WriteLine();

    // MIN a MAX
    int max = nums[0];
    int min = nums[0];
    double sum = 0;

    for (int i = 0; i < n; i++)
    {
        if (nums[i] > max)
            max = nums[i];

        if (nums[i] < min)
            min = nums[i];

        sum += nums[i];
    }
    Console.WriteLine($"\nPrůměrná hodnota je {sum / n}");

    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.Write($"Maximum bude {max} a jeho pozice je ");
    for (int i = 0; i < n; i++)
    {
        if (nums[i] == max)
            Console.Write($"{i + 1}; ");
    }
    Console.WriteLine();

    Console.Write($"Minimum bude {min} a jeho pozice je ");
    for (int i = 0; i < n; i++)
    {
        if (nums[i] == min)
            Console.Write($"{i + 1}; ");
    }

    /* bubble sort */
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (nums[j] < nums[j + 1])
            {
                int temp = nums[j];
                nums[j] = nums[j + 1];
                nums[j + 1] = temp;
            }
        }
    }

    /* INSERTION SORT
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
    } */

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine("Seřazená čísla pomocí bubble sort:");

    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", nums[i]);
    }

    // DRUHÉ, TŘETÍ, ČTVRTÉ NEJVĚTŠÍ ČÍSLO
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

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine("Druhé největší je " + second);
    Console.WriteLine("Třetí největší je " + third);
    Console.WriteLine("Čtvrté největší je " + fourth);

    // MEDIÁN
    int median;

    if (n % 2 == 1)
        median = nums[n / 2];
    else
        median = (nums[n / 2 - 1] + nums[n / 2]) / 2;

    Console.WriteLine();
    Console.WriteLine("======================================================");

    // BINÁRNÍ ZÁPIS
    string bin = "";
    int x = fourth;
    if (x == 0) bin = "0";
    
    while (x > 0)
    {
        bin = (x % 2) + bin;
        x /= 2;
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine($"Čtvrté největší číslo v binární soustavě: {fourth}(2) = {bin}");

    // VYKRESLOVÁNÍ OBRAZCE
    Console.WriteLine();
    Console.WriteLine("======================================================");

    int height = median;
    int width = third;

    Console.WriteLine($"Obrazec má výšku {height} a šířku {width}"); // meow
    Console.WriteLine();




    int part = height;
    Console.WriteLine("Printing a rhombus\n");


    // upper part fuck this shit
    for (int i = 0; i < height; i++)
    {
        int spaces = height - i - 1;
        int stars = 2 * i + 1;

        Console.Write(new string(' ', spaces * 2));

        for (int j = 0; j < stars; j++)
        {
            if (j == 0 || j == stars - 1 || stars == 1)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }

    //lower part
    for (int i = height - 2; i >= 0; i--)
    {
        int spaces = height - i - 1;
        int stars = 2 * i + 1;

        Console.Write(new string(' ', spaces * 2));

        for (int j = 0; j < stars; j++)
        {
            if (j == 0 || j == stars - 1 || stars == 2 * height - 2)
            Console.Write("* ");
            else
            Console.Write("  ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine() ?? "";
}