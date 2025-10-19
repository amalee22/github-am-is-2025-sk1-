using System;

string again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("*** Ciferný součet a součin ***");
    Console.WriteLine("*******************************");
    Console.WriteLine("****** Amálie Musilová ********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    // Načtení čísla od uživatele
    Console.Write("Zadejte celé číslo: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
    }

    int original = number;
    if (number < 0) number = -number; // práce s kladnou hodnotou

    int suma = 0;
    int soucin = 1;

    // Výpočet součtu a součinu číslic
    while (number > 0)
    {
        int cifra = number % 10;
        suma += cifra;
        soucin *= cifra;
        number /= 10;
    }

    Console.WriteLine();
    Console.WriteLine($"Součet cifer čísla {original} je: {suma}");
    Console.WriteLine($"Součin cifer čísla {original} je: {soucin}");
    Console.WriteLine();

    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
    again = Console.ReadLine() ?? "";
}
