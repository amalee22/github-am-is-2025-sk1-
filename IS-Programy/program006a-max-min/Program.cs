using System;

string again = "a";
while (again == "a" || again == "A")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("******* Generátor pseudonáhodných čísel ********");
    Console.WriteLine("************************************************");
    Console.WriteLine("************** Amálie Musilová *****************");
    Console.WriteLine("************************************************");
    Console.WriteLine();

    Console.Write("Vložte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

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

    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine("Hodnoty vstupů: ");
    Console.WriteLine($"Počet vygenerovaných hodnot: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound};");
    Console.WriteLine("======================================================");

    int[] myRandomNumbers = new int[n];
    Random myRandomNumber = new Random();

    int negativeNumbers = 0;
    int positiveNumbers = 0;
    int zeroNumbers = 0;
    int evenNumbers = 0;
    int oddNumbers = 0;

    Console.WriteLine();
    Console.WriteLine("Pseudonáhodná čísla: ");

    for (int i = 0; i < n; i++)
    {
        myRandomNumbers[i] = myRandomNumber.Next(lowerBound, upperBound + 1);
        Console.Write(myRandomNumbers[i] + "; ");

        int value = myRandomNumbers[i];

        if (value < 0) negativeNumbers++;
        else if (value > 0) positiveNumbers++;
        else zeroNumbers++;

        if (value % 2 == 0) evenNumbers++;
        else oddNumbers++;
    }
    Console.WriteLine();

    int maxValue = myRandomNumbers[0];
    int minValue = myRandomNumbers[0];
    int posMax = 0;
    int posMin = 0;

    for (int i = 1; i < n; i++)
    {
        if (myRandomNumbers[i] > maxValue)
        {
            maxValue = myRandomNumbers[i];
            posMax = i;
        }
        if (myRandomNumbers[i] < minValue)
        {
            minValue = myRandomNumbers[i];
            posMin = i;
        }
    }


//malování obrazce podle maxima
    if (maxValue >= 3) //hodnota musí být alespoň 3, aby se něco vykreslilo
    {
        for (int i = 0; i <= maxValue; i++)
        {
            int spaces, stars;

            if (i < (maxValue / 2))
            {
                spaces = i; // první polovina - v každém řádku je méně hvězdiček a více mezer - a od prostředku se to obrací - 
                stars = maxValue - (2 * i);         // méně mezer a více hvězdiček od poloviny 
            }
            else
            {
                spaces = maxValue - i - 1;

                if (maxValue % 2 == 1)
                {
                    stars = 2 * (i - (i - maxValue / 2)) + 1;
                }
                else
                {
                    stars = 2 * (i - maxValue / 2) + 2;
                }
            }
//SPACE
            for (int sp = 0; sp < spaces; sp++)
            {
                Console.Write(" ");
            }
//STARS
            for (int st = 0; st < stars; st++)
            {
                Console.Write("*");
            }

            Console.WriteLine();


//barvy 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Green;

            // mezery
            for (int sp = 0; sp < spaces; sp++)
                Console.Write(" ");

            // hvězdičky
            for (int st = 0; st < stars; st++)
                Console.Write("*");

            Console.WriteLine();
            Console.ResetColor();

        }

    }
    else
    {
        Console.WriteLine("Maximum je menší než 3 => obrazec se nevykreslí.");
    }

    Console.WriteLine();
    Console.WriteLine("=========================================");
    Console.WriteLine($"Maximum: {maxValue}");
    Console.WriteLine($"Pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimum: {minValue}");
    Console.WriteLine($"Pozice prvního minima: {posMin}");
    Console.WriteLine("=========================================");
    Console.WriteLine();

    int maxCount = 0;
    int minCount = 0;
    for (int i = 0; i < n; i++)
    {
        if (myRandomNumbers[i] == maxValue) maxCount++;
        if (myRandomNumbers[i] == minValue) minCount++;
    }

    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine($"Maximální hodnota: {maxValue}");
    Console.WriteLine($"Počet výskytů: {maxCount}");
    Console.Write("Pozice (index začínající na 0): ");
    bool firstPrinted = false;
    for (int i = 0; i < n; i++)
    {
        if (myRandomNumbers[i] == maxValue)
        {
            if (firstPrinted) Console.Write(", ");
            Console.Write(i);
            firstPrinted = true;
        }
    }

    Console.WriteLine();
    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine($"Minimální hodnota: {minValue}");
    Console.WriteLine($"Počet výskytů: {minCount}");
    Console.Write("Pozice (index začínající na 0): ");
    firstPrinted = false;
    for (int i = 0; i < n; i++)
    {
        if (myRandomNumbers[i] == minValue)
        {
            if (firstPrinted) Console.Write(", ");
            Console.Write(i);
            firstPrinted = true;
        }
    }

    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine();
    Console.WriteLine("Počet záporných čísel: " + negativeNumbers);
    Console.WriteLine("Počet kladných čísel: " + positiveNumbers);
    Console.WriteLine("Počet nul: " + zeroNumbers);
    Console.WriteLine();
    Console.WriteLine("Počet sudých čísel: " + evenNumbers);
    Console.WriteLine("Počet lichých čísel: " + oddNumbers);
    Console.WriteLine();
    Console.WriteLine("======================================================");

    Console.WriteLine();
    Console.WriteLine("Zadejte 'a' pro opakování programu, jinak stiskněte libovolnou klávesu pro ukončení.");
    again = Console.ReadLine() ?? string.Empty;
}