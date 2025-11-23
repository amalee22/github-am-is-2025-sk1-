using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("**************** Bubble Sort **************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("************* Amálie Musilová *************");
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

    Stopwatch myStopwatch = new Stopwatch();

    int compare = 0;
    int change = 0;
 
    // Algoritmus Bubble sort 
    myStopwatch.Start(); 
    for (int i = 0; i < n - 1; i++)  
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            compare++;
            if (myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int tmp = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = myRandNumbs[j];
                myRandNumbs[j] = tmp;
                change++;
            }
        }  
    }
    myStopwatch.Stop(); 

    // Výpis seřazených čísel
    Console.WriteLine();
    Console.WriteLine("================================");    
    Console.WriteLine();
    Console.WriteLine("Seřazená čísla: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    Console.WriteLine();
    Console.WriteLine($"Počet porovnání: {compare}");
    Console.WriteLine($"Počet výměn: {change}");
    Console.WriteLine("Čas potřebný na seřazení čísel: {0}", myStopwatch.Elapsed);


Console.WriteLine("================================");

//výpis proměnných - SecondLargest
int SecondLargest = myRandNumbs[1]; // Druhé největší číslo v seřazeném poli
Console.WriteLine($"Druhé největší číslo v poli je: {SecondLargest}"); // Výpis druhého největšího čísla 
int height = SecondLargest;
int width = SecondLargest; 


// Vytvoření obrazce                    u stringů se používá jenom ' ' místo " " (string funguje jinak, než jen writeline)
Console.WriteLine(new string('*', width));
Console.WriteLine(new string('*', width));// Horní okraj obrazce

//prostřed obrazce for cycle  
for (int i = 0; i < height - 2; i++)
{
    Console.WriteLine("*" + new string(' ', width - 2) + "*"); // Levý okraj obrazce
                        // Vytvoření prostoru uvnitř obrazce 
                        //největší číslo -2 (pro okraje)
} 

// Spodní okraj obrazce
Console.WriteLine(new string('*', width));
Console.WriteLine(new string('*', width));



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine()??""; // ošetření proti null hodnotě pokud je again not null tak to použije tu hodnotu, jinak prázdný string

} 