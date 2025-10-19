using System;

string again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("*** Ciferný součet a součin ***");
    Console.WriteLine("****************************");
    Console.WriteLine("****** Amálie Musilová ********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    Console.Write("Zadejte celé číslo: ");
    string input = Console.ReadLine() ?? "";

    // Ošetření, zda jde o celé číslo
    int number;
    while (!int.TryParse(input, out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
        input = Console.ReadLine() ?? "";
    }

    // Pokud je číslo záporné, odstraníme mínus
    if (input.StartsWith("-"))
        input = input.Substring(1);

    int suma = 0;
    int soucin = 1;

    // Práce s každým znakem (znak → číslice)
    foreach (char c in input)
    {
        int cifra = c - '0';  // převod znaku na číslo
        suma += cifra;
        soucin *= cifra;
    }

    Console.WriteLine();
    Console.WriteLine($"Součet cifer čísla {number} je: {suma}");
    Console.WriteLine($"Součin cifer čísla {number} je: {soucin}");
    Console.WriteLine();

    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
    again = Console.ReadLine() ?? "";
}
