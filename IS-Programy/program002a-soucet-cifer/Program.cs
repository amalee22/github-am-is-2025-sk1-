using System.Numerics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("******************************");
    Console.WriteLine("*** Součet a součin cifer ***");
    Console.WriteLine("******************************");
    Console.WriteLine("****** Amálie Musilová *******");
    Console.WriteLine("******************************");
    Console.WriteLine();

    // Vstup hodnoty do programu
    Console.Write("Zadejte celé číslo, pro které chcete spočítat součet a součin cifer: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    int soucet = 0;
    int soucin = 1;
    int zalohaCisla = number;
    int cifra; // proměnná pro jednotlivé cifry čísla

    // pokud je číslo záporné, převedeme ho na kladné
    if (number < 0)
    {
        number = -number;
    }

    while (number >= 10)
    {
        cifra = number % 10;
        number = (number - cifra) / 10;
        Console.WriteLine("Cifra = {0}", cifra);
        soucet += cifra;
        soucin *= cifra;
    }

    // zpracování poslední cifry
    Console.WriteLine("Cifra = {0}", number);
    soucet += number;
    soucin *= number;

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}", zalohaCisla, soucet);
    Console.WriteLine("Součin cifer čísla {0} je {1}", zalohaCisla, soucin);

    // modulo operace: v C# je to %, dělí na celočíselnou část a zbytek
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");

    again = Console.ReadLine() ?? "";

    // meow
    // zkouška push
}
