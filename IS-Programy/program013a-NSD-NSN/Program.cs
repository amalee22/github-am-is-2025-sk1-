﻿/* 
 * Program pro výpočet NSD (největší společný dělitel) 
 * a NSN (nejmenší společný násobek) dvou celých čísel.
 * Autor: Amálie Musilová
 */

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();

            // Zobrazení úvodní hlavičky programu
            razítko();

            // Načtení dvou vstupních čísel od uživatele
            ulong a = nactiCislo("Zadejte číslo a: ");
            ulong b = nactiCislo("Zadejte číslo b: ");

            // Výpočet NSD pomocí odečítacího algoritmu
            ulong nsd = vypocitatNSD(a, b);

            // Výpočet NSN pomocí vztahu: NSN = (a * b) / NSD
            ulong nsn = vypocitatNSN(a, b, nsd);

            // Výpis výsledků s barevným zvýrazněním
            zobrazitVysledky(a, b, nsd, nsn);

            // Dotaz na opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
            again = Console.ReadLine();
            Console.WriteLine();
        }
    }

    // Metoda pro zobrazení hlavičky programu
    static void razítko()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("****** Výpočet NSD a NSN ********");
        Console.WriteLine("*********************************");
        Console.WriteLine("******** Amálie Musilová ********");
        Console.WriteLine("*********************************");
    }

    // Metoda pro načtení čísla od uživatele s kontrolou vstupu
    static ulong nactiCislo(string zprava)
    {
        Console.Write(zprava);
        ulong cislo;
        string? vstup = Console.ReadLine();

        // Opakuj, dokud není zadáno platné celé číslo typu ulong
        while (vstup == null || !ulong.TryParse(vstup.Trim(), out cislo))
        {
            Console.Write("Nezadali jste celé číslo. Zkuste znovu: ");
            vstup = Console.ReadLine();
        }

        return cislo;
    }

    // Metoda pro výpočet NSD dvou čísel pomocí odečítání
    static ulong vypocitatNSD(ulong a, ulong b)
    {
        while (a != b)
        {
            if (a > b)
            {
                a = a - b; // odečti menší číslo od většího
            }
            else
            {
                b = b - a; // odečti menší číslo od většího
            }
        }
        return a; // po ukončení cyklu platí a = b = NSD
    }

    // Metoda pro výpočet NSN pomocí vztahu: NSN = (a * b) / NSD
    static ulong vypocitatNSN(ulong a, ulong b, ulong nsd)
    {
        return (a * b) / nsd;
    }

    // Metoda pro zobrazení výsledků s barevným výstupem
    static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("******************************");
        Console.WriteLine($"NSD čísel {a} a {b} je {nsd}.");
        Console.WriteLine("******************************");
        Console.WriteLine($"NSN čísel {a} a {b} je {nsn}.");
        Console.WriteLine("******************************");
        Console.WriteLine();
        Console.ResetColor(); // Vrátí barvy zpět na výchozí
    }
}