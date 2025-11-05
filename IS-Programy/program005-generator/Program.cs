﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel **********");
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

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }
    

Console.WriteLine();
Console.WriteLine("======================================================");
Console.WriteLine("Zadané hodnoty: "); //vypsání zadaných hodnot 
Console.WriteLine($"Počet generovaných čísel: {0}; Dolní mez :{1}; Horní mez: {2}", n, lowerBound, upperBound);
Console.WriteLine("======================================================");


    //DEKLARACE POLE
    // jen jmenování mé proměnné  ,  instance třídy int - nadeklarování pole celých čísel  
    int[] myRandomNumbers = new int[n];


    //vytvoření objektu  - POZOR- JEN NUMBER NE S - mn.č. /generování stejných čísel při stejném vstupu - hodí se pro TESTOVÁNÍ 
    Random myRandomNumber = new Random();

    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine("Pseudonáhodná čísla:  ");


    //cyklus  - jde také napsat pomocí WHILE 
for(int i = 0; i < n ; i ++)
        { //metoda .Next - 2 parametry - dolní a horní mez
        myRandomNumbers[i] = myRandomNumber.Next(lowerBound, upperBound);
        Console.WriteLine("{0}; ", myRandomNumbers[i]); 
        
        //i se zvětší na i++ = 1
    }


    Console.WriteLine("======================================================");


Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

    again = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.



}
