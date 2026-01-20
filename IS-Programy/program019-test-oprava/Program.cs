string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************************");
    Console.WriteLine("************** Zápočtový test IS **************");
    Console.WriteLine("************ Datum: 15. 1. 2026 ***************");
    Console.WriteLine("***************  Amálie Musilová **************");
    Console.WriteLine("***********************************************");
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
System.Console.WriteLine("--------------");


//selection sort
    for (int i = 0; i < n; i++)
    {

        int maxIndex = i;
        for (int j = i +1 ; j < n; j++)
            if (myRandNumbs[j] > myRandNumbs[maxIndex])
                maxIndex = j;

        int temp = myRandNumbs[i];
        myRandNumbs[i] = myRandNumbs[maxIndex];
        myRandNumbs[maxIndex] = temp;
        
    }
System.Console.WriteLine();
    System.Console.WriteLine("Seřazeno podle Selection sort:  ");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{myRandNumbs[i]}, ");
    }
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
    System.Console.WriteLine("Seřazeno i podle Bubble sort:  ");
    for (int i = 0; i < n; i++)
    {
        System.Console.Write("{0}, ", myRandNumbs[i]);
    }



    
    System.Console.WriteLine();
System.Console.WriteLine();
  System.Console.WriteLine("-------");
  System.Console.WriteLine();


        // max
        int max = myRandNumbs[0];
    int min = myRandNumbs[0];
        int sum = 0;//suma


    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] > max)
            max = myRandNumbs[i];

        if (myRandNumbs[i] < min)
            min = myRandNumbs[i];


        sum += myRandNumbs[i]; //pro sumu a averge
    }

    System.Console.WriteLine();
    System.Console.Write($"maximum: {max} ");
    
    System.Console.WriteLine();
  



    //druhy třetí čtvrtý největší

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
        

      System.Console.WriteLine($"Druhé největší číslo:  {second}" );

      System.Console.WriteLine("Třetí největší číslo: " + third);

      System.Console.WriteLine("Čtvrté největší číslo: " + fourth);


    System.Console.WriteLine();
  System.Console.WriteLine("-------");
  System.Console.WriteLine();


    // součet cifer maxima
    int tmpMax = max, sumDigits = 0;
    while (tmpMax > 0)
    {
        sumDigits == sumDigits + tmpMax % 10;
        tmpMax == tmpMax / 10;
    }
    Console.WriteLine("Součet cifer u maxima: " + sumDigits); 



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

    

    //součet vyg čísel
        System.Console.WriteLine($"Součet vygenerovaných čísel: {sum}"); //nahoře je k tomu fce u max min 



    //průměr se zbytkem
    int avgInt = sum/n;
    int remainder = sum % n;

    System.Console.WriteLine($"Průměr vygenerovaných čísel určený celočíselně: celá část = {avgInt}, zbytek = {remainder}");




    System.Console.WriteLine();
System.Console.WriteLine("-------");
    System.Console.WriteLine();


    //nsd a nsn
    int a = max, b = third;
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }

    int nsd = a;
    int nsn = (max*third) / a;

    System.Console.Write("Největší společný dělitel maxima a třetího největšího čísla. ");
    Console.WriteLine($"NSD čísel {max} a {third} je: {nsd}");
    
    System.Console.Write("Nejmenší společný násobek maxima a třetího největšího čísla. ");
    Console.WriteLine($"NSN čísel {max} a {third} je: {nsn}") ;


    System.Console.WriteLine();
System.Console.WriteLine("-------");
    System.Console.WriteLine();

    //vykreslení obrazce

    System.Console.WriteLine();

    System.Console.WriteLine($"Obrazec,jehož výška je řízena čtvrtým největším číslem (zde {fourth}) a šířka celou částí průměru (zde {avgInt})");
System.Console.WriteLine();

    //používat fourth a avgInt...

  if (fourth > 0 && avgInt > 0)
    {
        Console.WriteLine("\nObrazec:");

        bool vlevo = true;   // strana spojovacího znaku
        char znak = '*';     // počáteční znak
        int pocetRadku = 0;

        while (pocetRadku < fourth) //zavisí to na fourth - pokud je to větší tak to nejde 
        {
            // plná vodorovná řada
            for (int j = 0; j < avgInt; j++)
                Console.Write(znak + " "); //with - ten znak a space 
            Console.WriteLine();
            pocetRadku++; // zvýšení počtu vykreslených řádků

            if (pocetRadku >= fourth) break; // kontrola počtu řádků a pokud je splněno, tak přerušit smyčku

            // spojovací svislý znak
            if (vlevo)
            {
                Console.WriteLine(znak);
            }
            else
            {
                for (int j = 0; j < avgInt - 1; j++) //-1 protože ten znak je na konci
                    Console.Write("  ");
                Console.WriteLine(znak); //znak na konci řádku
            }
            pocetRadku++; // další zvýšení počtu vykreslených řádků

            // změna znaku a strany
            if (znak == '*') { //tohle určuje ten přepínač mezi * a #
                znak = '#';
            }
            else {
                znak = '*';
            }
            vlevo = !vlevo; //false to the boolean vlevo
        }
    }
    else
    {
        Console.WriteLine("\nObrazec nelze vykreslit.");
        }














    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;	
    Console.WriteLine("=============================================");
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    Console.ResetColor();
    again = Console.ReadLine();
}