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
    {                   // první while cyklus pro kontrolu vstupu - pokud uživatel nezadá celé číslo, tak ho to neposune dál !!! 
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
        if (upperBound < lowerBound) //statement pro kontrolu, zda je horní mez větší než dolní mez
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
    Console.WriteLine("Hodnoty vstupů: ");      //$ ukazuje zadané hodnoty - pokud tam není, tak to nebere proměnné 
    Console.WriteLine($"Počet vygenerovaných hodnot: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound};");
    Console.WriteLine("======================================================");


//array declaration - array of ints - size n (user defined) 
    int[] myRandomNumbers = new int[n];
    Random myRandomNumber = new Random();


    int negativeNumbers = 0;
    int positiveNumbers = 0;
    int zeroNumbers = 0;
    int evenNumbers = 0;
    int oddNumbers = 0;

    Console.WriteLine();
    Console.WriteLine("Pseudonáhodná čísla: "); // vypíše vygenerovaná čísla uživateli 

    for (int i = 0; i < n; i++)
    {
        myRandomNumbers[i] = myRandomNumber.Next(lowerBound, upperBound + 1);
        Console.Write(myRandomNumbers[i] + "; ");

        int value = myRandomNumbers[i];

        if (value < 0) negativeNumbers++;
        else if (value > 0) positiveNumbers++;
        else zeroNumbers++;

        if (value % 2 == 0) evenNumbers++;  //modulo % 
        else oddNumbers++;  //nechceme lichá čísla
    }


    Console.WriteLine();

    int maxValue = myRandomNumbers[0];
    int minValue = myRandomNumbers[0]; //ještě nevíme jaké to bude číslo, tak řekneme že to bude první číslo z pole
    int posMax = 0;
    int posMin = 0;

    for (int i = 1; i < n; i++)
    {// jaké číslo je nejvě tší a jaké nejmenší - vezme to ty vybraná čísla 
        if (myRandomNumbers[i] > maxValue)
        {
            maxValue = myRandomNumbers[i]; //uložení nové maximální hodnoty
            posMax = i;
        }
        if (myRandomNumbers[i] < minValue)
        {
            minValue = myRandomNumbers[i];
            posMin = i; //uložení nové minimální hodnoty 
        }
    }


    // Drawing the hourglass
    if (maxValue >= 3)
    {
        for (int i = 0; i < maxValue; i++)
        {
            int spaces, stars;
            if (i < maxValue / 2)
            {
                spaces = i;
                // upper half - every next line has two fewer stars (one from each side) 
                stars = maxValue - (2 * i);
            }
            else
            {
                spaces = maxValue - i - 1;
                if (maxValue % 2 == 1)
                {
                    stars = 2 * (i - maxValue / 2) + 1;
                }
                else
                {
                    stars = 2 * (i - maxValue / 2) + 2;
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            // sp - space
            for (int sp = 0; sp < spaces; sp++)
            {
                Console.Write(" ");
            }
            // st - star
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