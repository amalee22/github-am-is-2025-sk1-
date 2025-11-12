using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

string again = "a";
while (again == "a" || again == "A") // bere to jak malá tak i velká a B)
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("******* Generátor pseudonáhodných čísel ********");
    Console.WriteLine("************************************************");
    Console.WriteLine("************** Amálie Musilová *****************"); // mbtflld :3
    Console.WriteLine("************************************************");
    Console.WriteLine();


    Console.Write("vložte počet generovaných čísel (celé číslo): ");
    int n; // pro počet čísel n
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: "); 
    }


    // LOWER BOUND
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }


    // UPPER BOUND - horní mez
    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    // vysvětlení: dokud vstup není celé číslo *NEBO* je horní mez MENŠÍ než dolní mez
    {
        if (upperBound < lowerBound) //pokud je horní mez menší než dolní mez
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
    Console.WriteLine("Input values: "); // ukazuje zadané hodnoty
    Console.WriteLine($"Počet vygenerovaných hodnot: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound};");
    Console.WriteLine("======================================================");


    // ARRAY DECLARATION
    // jen pojmenování pole pro uložení generovaných čísel
    int[] myRandomNumbers = new int[n];


    // creating the object - POZOR ! - ČÍSLA NEJSOU TAK NÁHODNÁ JAKO BYCHOM CHTĚLI !
    // generování stejných čísel pro stejný vstup - používá se pro testování
    Random myRandomNumber = new Random();

    // záporné kladné nuly
    int negativeNumbers = 0; // resetování záporných čísel
    int positiveNumbers = 0; // resetování kladných čísel
    int zeroNumbers = 0; // resetování nulových čísel

    // sudá lichá čísla
    int evenNumbers = 0; // resetování sudých čísel
    int oddNumbers = 0; // resetování lichých čísel


    Console.WriteLine();
    Console.WriteLine("Pseudonáhodná čísla: ");

    for (int i = 0; i < n; i++) // loop pro generování n čísel
    {
        myRandomNumbers[i] = myRandomNumber.Next(lowerBound, upperBound + 1); // +1 protože upper bound je EXKLUZIVNÍ
        Console.Write(myRandomNumbers[i] + "; "); // vypsání generovaných čísel

        int value = myRandomNumbers[i];

        // positive or negative - pár else ifs :P pro efektivitu 
        if (value < 0)
        {
            negativeNumbers++;
        }
        else if (value > 0)
        {
            positiveNumbers++;
        }
        else
        {
            zeroNumbers++;
        }

        // sudé nebo liché a 0 je sudé :PPP
        if (value % 2 == 0)
        {
            evenNumbers++;
        }
        else
        {
            oddNumbers++;
        }
    }
    Console.WriteLine();

    // MAXIMUM AND MINIMUM HODNOTY - HLEDÁNÍ HODNOT - DEFAULT JE první číslo ARRAYE
    int maxValue = myRandomNumbers[0];
    int minValue = myRandomNumbers[0];
 
 int posMax = 0;
    int posMin = 0;


    // první cyklus pro nalezení max a min hodnot - zkontroluje všechny hodnoty v poli jestli jsou větší nebo menší než aktuální max a min
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




    if (maxValue >= 3)
    {

        for (int i = 0; i <= maxValue; i++)
        {
            //CYKLUS - dodržení správného počtu řádků  - má mít tři části 
            int spaces, stars;
            if (i < (maxValue / 2))

                spaces = i;
            //horní polovina - s každým řádkem se hvězdiček přibývá o 2 (po jedné z každé strany´)
            stars = maxValue - (2 * i);

        //např max 10   10 - 2*0   = 10
        // 10    10 - 2*1   = 8
        // 10   10 - 2*2   = 6
        //10  10 - 2*3   = 4
        //10 10 - 2*4   = 2
        // 10 10 - 2*5   = 0

            else
            {
                spaces = maxValue - i - 1;

                //procento = modulo % 
                if (maxValue % 2 == 1)
                {
                    stars = 2 * (i - (i - maxValue / 2)) + 1;
                }

                else
                {
                    stars = stars = 2 * (i - maxValue / 2) + 2;

                }

                //SP = SPACE 
                for (int sp = 0; sp < spaces; sp++)
                {
                    Console.Write(" ");
                }


                //ST = STARS
                for (int st = 0; st < stars; st++)
                {
                    Console.Write("*");//jen write ne writeline protože chceme aby to bylo na jednom řádku
                }


            }

            Console.WriteLine(); // nový řádek po každém řádku obrazce
        }
    else {
                Console.WriteLine("Maximum je menší než 3 => obrazec se nevykreslí.");
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine("=========================================");
    Console.WriteLine($"Maximum: {  maxValue}");
    Console.WriteLine($"Pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimum: {minValue  }");
    Console.WriteLine($"Pozice prvního minima: {posMin}");
    Console.WriteLine("=========================================");
    Console.WriteLine();





    // kolikrát se maximum a minimum v poli vyskytuje - druhý cyklus další FOR LOOP
    int maxCount = 0;
    int minCount = 0;
    for (int i = 0; i < n; i++)
    {
        if (myRandomNumbers[i] == maxValue)
        {
            maxCount++;
        }
        if (myRandomNumbers[i] == minValue)
        {
            minCount++;
        }
    }

    //  ZOBRAZENÍ VÝSLEDKŮ MAX A MIN - vypíše to úplně všechno co potřebujeme vědět o maximu a minimu
    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine($"Maximální hodnota: {maxValue}");
    Console.WriteLine($"Počet výskytů: {maxCount}");
    Console.Write("Pozice (index začínající na 0): ");
    bool firstPrinted = false;
    // pomáhá to s formátováním výpisu - aby to nevypadalo ošklivě
   
    // bez tohoto ifu by to vypsalo čárku i před prvním číslem což nevypadá dobře
    for (int i = 0; i < n; i++)
    {
        if (myRandomNumbers[i] == maxValue)
        {
            if (firstPrinted) // pokud už bylo něco vytištěno - PÍŠE TO ČÁRKU NE PŘED PRVNÍM ČÍSLEM
            {
                Console.Write(", ");
            }
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
            if (firstPrinted)
            {
                Console.Write(", ");
            }
            Console.Write(i);
            firstPrinted = true;
        }
    }
    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine();

    Console.WriteLine("======================================================");
    Console.WriteLine();
    Console.WriteLine("počet záporných čísel: " + negativeNumbers);
    Console.WriteLine("počet kladných čísel: " + positiveNumbers);
    Console.WriteLine("počet nul: " + zeroNumbers);
    Console.WriteLine();
    Console.WriteLine("počet sudých čísel: " + evenNumbers);
    Console.WriteLine("počet lichých čísel: " + oddNumbers);
    Console.WriteLine();
    Console.WriteLine("======================================================");

    Console.WriteLine();
    Console.WriteLine("Zadejte 'a' pro opakování programu, jinak stiskněte libovolnou klávesu pro ukončení.");


    again = Console.ReadLine() ?? string.Empty;
}