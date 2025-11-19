using System.Diagnostics; // StopWatch je v této knihovně

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("******************* Bubble sort ****************");
    Console.WriteLine("************************************************");
    Console.WriteLine("************** Amálie Musilová *****************");
    Console.WriteLine("************************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n; //proměnná pro počet čísel n  

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    //DOLNÍ MEZ  
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    //HORNÍ MEZ  
    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        if (upperBound < lowerBound)
        {
            Console.Write($"horní mez musí být větší než dolní mez ({lowerBound}). Zadejte horní mez znovu: ");
        }
        else
        {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
        }
    }

    //DEKLARACE POLE - ARRAY hooray
    int[] myRandomNumbers = new int[n];

    //vytvoření objektu Random - generování stejných čísel při stejném vstupu - hodí se pro TESTOVÁNÍ  
    Random myRandomNumber = new Random();

    //naplnění pole náhodnými čísly
    for (int i = 0; i < n; i++)
    {
        myRandomNumbers[i] = myRandomNumber.Next(lowerBound, upperBound + 1);
    }

    //ŘEŠÍ ZÁPORNÁ, KLADNÁ A NULOVÁ ČÍSLA
    int negativeNumbers = 0; // vynulování záporných čísel  
    int positiveNumbers = 0; // vynulování kladných čísel
    int zeroNumbers = 0;     // vynulování nulových čísel

    //2. kategorie - SUDOST A LICHOST  
    int evenNumbers = 0; // vynulování sudých čísel
    int oddNumbers = 0;  // vynulování lichých čísel

    int compare = 0;
    int change = 0;

    // STOPWATCH - měření času běhu algoritmu
    Stopwatch sw = new Stopwatch();
    sw.Start();
 
    //BUBBLE SORT - generování náhodných čísel do pole  
    for (int i = 0; i < n - 1; i++) //hlavní operace se provedou tolikrát, kolik je prvků v poli
    {
        for (int j = 0; j < n - i - 1; j++) //vnořený cyklus - porovnáváme vždy dva sousední prvky
        {
            compare++; //počítadlo porovnání

            if (myRandomNumbers[j] > myRandomNumbers[j + 1]) //porovnání dvou sousedních prvků - hned následný - PROTO j + 1
            {
                //prohodit hodnoty - NOVÁ PROMĚNNÁ TEMP JAKO TEMPORARY - DOČASNÁ PROMĚNNÁ
                int temp = myRandomNumbers[j + 1]; 
                myRandomNumbers[j + 1] = myRandomNumbers[j]; 
                myRandomNumbers[j] = temp; 

                // POKUD SE STANE IF, TAK DOJDE K VÝMĚNĚ HODNOT  
                change++; //počítadlo změn hodnot
            }
        }
    }

    sw.Stop(); // zastavení měření času

    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine("Zadané hodnoty: "); //vypsání zadaných hodnot  
    Console.WriteLine($"Počet generovaných čísel: {n}; Dolní mez :{lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("======================================================");

    Console.WriteLine("Pseudonáhodná čísla (seřazená):  ");
    for (int i = 0; i < n; i++) // cyklus pro výpis n čísel
    {
        Console.Write("{0}; ", myRandomNumbers[i]); //výpis generovaných čísel +" " - mezera mezi číslíčky :)   
    }
    Console.WriteLine();

    Console.WriteLine($"Počet porovnání: {compare}");
    Console.WriteLine($"Počet změn: {change}");
    Console.WriteLine($"Čas běhu algoritmu: {sw.ElapsedMilliseconds} ms"); // výpis času v milisekundách

    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
#pragma warning disable CS8600 // Converting null literal or possible null value to  
    again = Console.ReadLine();
}