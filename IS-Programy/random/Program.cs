
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Numerics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Zápočtový test IS ************");
    Console.WriteLine("************* Datum: 8. 1. 2026 *****************");
    Console.WriteLine("********  Amálie Musilová ********");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
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

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");

    int[] myRandNumbs = new int[n];

    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbs[i]);
    }
    
    System.Console.WriteLine();
System.Console.WriteLine("-------");
System.Console.WriteLine();


    //min a max
    int max = myRandNumbs[0];
    int min = myRandNumbs[0];

    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] > max)
            max = myRandNumbs[i];

        if (myRandNumbs[i] < min)
            min = myRandNumbs[i];

    }

    System.Console.WriteLine();
    System.Console.Write($"maximum je {max} a jeho pozice je:  ");
    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] == max)
            System.Console.Write($"{i + 1}, ");
    }
    
    System.Console.WriteLine();
    System.Console.Write($"minimum je {min} a jeho pozice je:  ");
    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] == min)
            System.Console.Write($"{i + 1}, ");
    }
  System.Console.WriteLine();
System.Console.WriteLine("-------");
System.Console.WriteLine();





//bubble sort 

 for (int i  = 0; i < n - 1; i++)
{
        for (int j = 0; j < n - i - 1; j++)
        {
            if (myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int temp = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = myRandNumbs[j];
                myRandNumbs[j] = temp;

            }
    }
}
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine("čísla seřazená podle bubble sort:  ");
    for (int i = 0; i < n; i++)
    {
        System.Console.Write("{0}, ", myRandNumbs[i]);
    }

 System.Console.WriteLine();
  System.Console.WriteLine("-------");
  System.Console.WriteLine();


    //druhy třetí čtvrtý nej. 

    int uniqueCount = 0;
    int lastValue = int.MinValue;
    int second = 0, third = 0, fourth = 0;
    for (int i = 0; i < n; i++)
        if (myRandNumbs[i] != lastValue)
        {
            uniqueCount++;
            lastValue = myRandNumbs[i];

            if (uniqueCount == 2)
                second = myRandNumbs[i];

            if (uniqueCount == 3)
                third = myRandNumbs[i];
            
            if (uniqueCount == 4)
                fourth  = myRandNumbs[i];

        }
        

      System.Console.WriteLine($"Druhé největší číslo je: {second}" );

      System.Console.WriteLine("Třetí největší číslo je: " + third);

      System.Console.WriteLine("Čtvrté největší číslo je: " + fourth);


    System.Console.WriteLine();
  System.Console.WriteLine("-------");
  System.Console.WriteLine();

        //binary
    string bin = "  ";
                int cislo = fourth;
                if (cislo == 0) bin = "0";
    while (cislo > 0) 
                {
                    bin = (cislo % 2)+ bin;
                     cislo /= 2;
                }
                 System.Console.WriteLine($"Čtvrté největší číslo převedené do dvojkové soustavy {fourth} (10) = {bin} (2)");

  System.Console.WriteLine();
System.Console.WriteLine("-------");
System.Console.WriteLine();

    //median
    int median = 0;
    if (n % 2 == 1)
        median = myRandNumbs[n / 2];
    else
        median = (myRandNumbs[n / 2 - 1] + myRandNumbs[n / 2]) / 2;

    System.Console.WriteLine($"Medián vygenerovaných čísel: {median}");

System.Console.WriteLine();
System.Console.WriteLine("-------");
    System.Console.WriteLine();

    //vykreslení obrazce
    System.Console.WriteLine("Atypická šachovnice (obdélník, kde se střídají znaky)");
    System.Console.WriteLine($"Výška: třetí největší číslo ( {third}); Šířka: medián ({median})");

    

    if (third > 0 && median > 0)
    {
        for (int radek = 0; radek < third; radek++)
        {
            for (int sloupec = 0; sloupec < median; sloupec++)
            {
                if (radek == 0 || radek == third - 1 || sloupec == 0 || sloupec == median - 1) //or - || 
                {
                    Console.Write("* # ");
                    
                   }

                else
                {
                    System.Console.Write("* # ");
                }
                
            }
System.Console.WriteLine();

        }


    }

















   



        Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("=============================================");
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    Console.ResetColor();
    again = Console.ReadLine()?? ""; //null
}

