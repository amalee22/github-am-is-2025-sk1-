using System.ComponentModel;
using System.Data.Common;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
    Console.WriteLine("*******************************************");
    Console.WriteLine("****************** Amy  *******************");
    Console.WriteLine("*******************************************");
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

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0}; ", myRandNumbs[i]);
    }




int max = myRandNumbs[0];
int min = myRandNumbs[0];
double soucet = 0; // Pomocná proměnná pro průměr

for (int i = 0; i < n; i++)
{
    if (myRandNumbs[i] > max) max = myRandNumbs[i];
    if (myRandNumbs[i] < min) min = myRandNumbs[i];
    soucet += myRandNumbs[i]; // Sčítáme pro průměr
}
double prumer = soucet / n;
Console.WriteLine();
Console.WriteLine($"\nPrůměr všech čísel je: {prumer:F2}");
Console.Write($"Max je {max} a jeho pozice je:  ");
for (int i = 0; i < n; i++)
{
    if (myRandNumbs[i] == max) Console.Write($"{i + 1}, ");
}
Console.WriteLine();
Console.Write($"Min je {min} a jeho pozice je:  ");
for (int i = 0; i < n; i++)
{
    if (myRandNumbs[i] == min) Console.Write($"{i + 1}, ");
}

/*BUBBLE
for (int i = 0; i < n - 1; i++ )
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (myRandNumbs[j] < myRandNumbs[j+1])
            {
                int pom = myRandNumbs[j+1];
                myRandNumbs[j+1] = myRandNumbs[j];
                myRandNumbs[j] = pom;
            }

        }
    }
System.Console.WriteLine();
System.Console.WriteLine("čísla jsou ");
for (int i = 0; i < n; i++)
    {
        System.Console.Write("{0}  ", myRandNumbs[i]);
    }
*/

// SHAKER SORT (sestupně, aby ti fungovalo hledání 2. a 3. největšího čísla)
int left = 0;
int right = n - 1;
bool swapOccurred = true;

while (left < right && swapOccurred)
{
    swapOccurred = false;

    // Průchod zleva doprava (vytlačí nejmenší prvek na konec při sestupném řazení)
    for (int i = left; i < right; i++)
    {
        if (myRandNumbs[i] < myRandNumbs[i + 1])
        {
            int pom = myRandNumbs[i];
            myRandNumbs[i] = myRandNumbs[i + 1];
            myRandNumbs[i + 1] = pom;
            swapOccurred = true;
        }
    }
    right--; // Zmenšíme pravou hranici

    // Průchod zprava doleva (vytlačí největší prvek na začátek)
    for (int i = right; i > left; i--)
    {
        if (myRandNumbs[i] > myRandNumbs[i - 1])
        {
            int pom = myRandNumbs[i];
            myRandNumbs[i] = myRandNumbs[i - 1];
            myRandNumbs[i - 1] = pom;
            swapOccurred = true;
        }
    }
    left++; // Zvětšíme levou hranici
}

System.Console.WriteLine();
System.Console.WriteLine("Čísla jsou (seřazeno Shaker Sortem):");
for (int i = 0; i < n; i++)
{
    System.Console.Write("{0}  ", myRandNumbs[i]);
}



int uniqueCount = 0;
int lastValue = int.MinValue;
int second  = 0, third = 0;

for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] != lastValue)
        {
            uniqueCount++;
            lastValue = myRandNumbs[i];

            if (uniqueCount == 2)
            second = myRandNumbs[i];
            if (uniqueCount == 3)
            third = myRandNumbs[i];
        }
    }
System.Console.WriteLine();
System.Console.Write($"druhé nejvěší číslo je {second} a třetí je {third}");

System.Console.WriteLine();

//to binary
string bin = "   ";
int cislo = third;
if (cislo == 0) bin = "0";
while (cislo > 0)
    {
         bin = (cislo % 2) + bin;
         cislo = cislo / 2;
    }
System.Console.WriteLine($"třetí největší číslo {third} v binary je {bin}");


int median;
if (n % 2 == 1)
    median = myRandNumbs[n / 2];
else 
    median = (myRandNumbs[n / 2 - 1] + myRandNumbs[n/2])/2;

    System.Console.WriteLine(
    );
System.Console.WriteLine($"medián je {median}");



System.Console.WriteLine();
System.Console.WriteLine("=============================================");
System.Console.WriteLine($"Vykreslení obrysu obdélníku (Výška: {median}, Šířka: {second})");
System.Console.WriteLine();
if (median > 0 && second > 0)
{
    for (int radek = 0; radek < median; radek++)
    {
        for (int sloupec = 0; sloupec < second; sloupec++)
        {
            if (radek == 0 || radek == median - 1 || sloupec == 0 || sloupec == second - 1)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  "); // Vnitřek je prázdný (dvě mezery pro zachování proporcí)
            }
        }
        Console.WriteLine(); // Konec řádku
    }
}
else
{
    Console.WriteLine("Obdélník nelze vykreslit (rozměry musí být větší než 0).");
}


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine()?? "";


}