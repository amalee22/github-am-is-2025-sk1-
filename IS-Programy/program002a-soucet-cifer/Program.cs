using System.Numerics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***Ciferný součet a součin**");
    Console.WriteLine("****************************");
    Console.WriteLine("******Amálie Musilová*******");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // vstup hodnoty do programu 
    Console.Write("Zadejte celé číslo pro nějž chcete určit součet a součin: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    int suma = 0;
    int numberBackup = number; //záloha původního čísla pro výpočet součinu
    int digit; //proměnná pro jednotlivé cifry čísla

    if (number < 0)
    {
        number = -number; //převedení na kladné číslo
    }

    while (number >= 10) //dokud je číslo větší nebo rovno 10, bude cyklus pokračovat;
    {
        digit = number % 10; //získání zbytku po dělení 10, bude nám půjdčovat jednotolivé cifry
        number = (number - digit) / 10; //od čísla odečteme získanou cifru a vydělíme 10, čímž se posuneme na další cifru
        Console.WriteLine("Digit = {0}", digit);
        suma = suma + digit;//sčítání jednotlivých cifer


        //nesmíme zapomenout přičíst podlesní číslici do sumy
        suma = suma + number;

        Console.WriteLine();
        Console.WriteLine("součet cifer čísla {0} je {1}", numberBackup, suma);

    }
        
    //modulo . dělení se zbytkem - v C# je to % - dělí se na celou část a zbytek 

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");

    again = Console.ReadLine() ?? ""; 
    //meow

    //zkouška pushe
}