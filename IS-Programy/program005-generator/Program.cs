﻿using System.Diagnostics.CodeAnalysis;

string again = "a";
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

    //ŘEŠÍ ZÁPORNÁM KLADNÁ A NULOVÁ ČÍSLA
    int negativeNumbers = 0; // vynulování záporných čísel 
    int positiveNumbers = 0; // vynulování kladných čísel
    int zeroNumbers = 0; // vynulování nulových čísel

    //2. kategorie - SUDOST A LICHOST 
    int evenNumbers = 0; // vynulování sudých čísel
    int oddNumbers = 0; // vynulování lichých čísel


    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine("Pseudonáhodná čísla:  ");

    for (int i = 0; i < n; i++) // cyklus pro generování n čísel
    {
        myRandomNumbers[i] = myRandomNumber.Next(lowerBound, upperBound + 1); // generování čísel do pole - metoda Next - generování čísel v zadaném rozsahu

        /* if (myRandomNumbers[i] < 0)
         {
             negativeNumbers++; //počítadlo záporných čísel - nebo také = + 1;, ale plus plus je lepší 
         }

         if (myRandomNumbers[i] > 0)
         {
             positiveNumbers++; //počítadlo kladných čísel
         }

         if (myRandomNumbers[i] == 0)
         {
             zeroNumbers++; //počítadlo nulových čísel
         }
         */ // není efektivní 


        //EFFECTIVE VERSION - je výdy lepší použít ELSE IF - protože číslo může být jen jedno z těchto tří stavů
        if (myRandomNumbers[i] < 0)
            negativeNumbers++; //počítadlo záporných čísel - nebo také = + 1;, ale plus plus je lepší 
        else if (myRandomNumbers[i] > 0)
            positiveNumbers++; //počítadlo kladných čísel
        else
            zeroNumbers++; //počítadlo nulových čísel



        if (myRandomNumbers[i] % 2 == 0)
        {
            evenNumbers++; //počítadlo sudých čísel
        }
        else
        {
            oddNumbers++; //počítadlo lichých čísel 

        }

    }
    Console.WriteLine("======================================================");
        Console.WriteLine("======================================================");
        Console.WriteLine("======================================================");
        Console.WriteLine();

        Console.WriteLine("Počet záporných čísel: {0}" + negativeNumbers);
        Console.WriteLine("Počet kladných čísel: {0}" + positiveNumbers);
        Console.WriteLine("Počet nulových čísel: {0}" + zeroNumbers);

        Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine("======================================================");
    Console.WriteLine("======================================================");
        
    Console.WriteLine("Počet sudých čísel: {0}" + evenNumbers);
    Console.WriteLine("Počet lichých čísel: {0}" + oddNumbers);

        Console.WriteLine("======================================================");
        Console.WriteLine("======================================================");
Console.WriteLine("======================================================");




        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
#pragma warning disable CS8600 // Converting null literal or possible null value to 


    
}