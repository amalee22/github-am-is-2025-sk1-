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
            
             // || upperbound < lowerbound - dvě čárky jsou OR - je to číslo nebo není číslo n  a zároveň je horní mez větší než dolní mez
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    // explaination: while the input is not an integer *OR* the upper bound is LESS THAN the lower bound
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


    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine("Zadané hodnoty: "); //vypsání zadaných hodnot 
    Console.WriteLine($"Počet generovaných čísel: {n}; Dolní mez :{lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("======================================================");


    //DEKLARACE POLE - ARRAY hooray
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
        myRandomNumbers[i] = myRandomNumber.Next(lowerBound, upperBound + 1);

        Console.Write(myRandomNumbers[i] + " "); //výpis generovaných čísel +" " - mezera mezi číslíčky :)   
    }
    Console.WriteLine();

    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");



again = Console.ReadLine()?? "";
}