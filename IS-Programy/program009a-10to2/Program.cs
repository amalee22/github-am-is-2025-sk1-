﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*************************************");
    Console.WriteLine("***** Převod z 10 do 2 soustavy *****");
    Console.WriteLine("*************************************");
    Console.WriteLine("********** Amálie Musilová ***********");
    Console.WriteLine("*************************************");
    Console.WriteLine();

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte hodnotu (přirozené číslo) - desítkové číslo: ");
    int number10;

    while (!int.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte hodnotu znovu (přirozené číslo) - desítkové číslo: ");
    }

    int backupNumber10 = number10;
    int zbytek;

    int[] myArray = new int[32];

    int i;
    for (i = 0; number10 > 0; i++)
    {
        zbytek = number10 % 2;
        number10 = (number10 - zbytek) / 2;
        myArray[i] = zbytek;

        Console.WriteLine("Celá část = {0}; Zbytek = {1}", number10, zbytek);
    }

    Console.WriteLine();
    for (int j=i-1;j>=0;j--) {
        Console.Write("{0}", myArray[j]);
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}