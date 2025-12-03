﻿string again = "a";
while (again == "a")
{
Console.Clear();
Console.WriteLine("****************************");
Console.WriteLine("******** Výpočet PI ********");
Console.WriteLine("****************************");
Console.WriteLine("***** Amálie Musilová ******");
Console.WriteLine("****************************");
Console.WriteLine();

Console.Write("Zadejte přesnost (reálné číslo - čím menší hodnota, tím bude výpočet přesnější): ");
double presnost;
while(!double.TryParse(Console.ReadLine(), out presnost)) {
Console.Write("Nezadali jste reálné číslo, zadejte přesnost znovu: ");
}

double i = 1; //jmenovatel
double znamenko = 1; //počáteční znaménko
double piCtvrt = 1; 

    while((1/i)>=presnost) { //pokud je hodnota členu větší nebo rovna než zadaná přesnost, pokračuj ve výpočtu
        i = i + 2; //zvětšení jmenovatele o 2
        znamenko = -znamenko; //změna znaménka
        piCtvrt = piCtvrt + znamenko * (1/i); //přičtení dalšího členu do součtu

        if(znamenko==1) {//kladné znaménko
            Console.WriteLine("Zlomek: +1/{0}; aktuální hodnota PI = {1}", i, 4 * piCtvrt);//výpis aktuální hodnoty
        }
        else {
            Console.WriteLine("Zlomek: -1/{0}; aktuální hodnota PI = {1}", i, 4 * piCtvrt);//záporné znaménko
        }
    }

    Console.WriteLine("\n\n Hodnota čísla PI = {0}", 4 * piCtvrt);
    //Console.WriteLine("\n\n Hodnota čísla PI = {0:f4}", 4 * piCtvrt);

Console.WriteLine();
Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
again = Console.ReadLine();


}


