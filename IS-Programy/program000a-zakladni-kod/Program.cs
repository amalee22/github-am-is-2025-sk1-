﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Název programu **********");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Amálie Musilová ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte hodnotu (celé číslo): ");
    int first;

    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

    again = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.



}
