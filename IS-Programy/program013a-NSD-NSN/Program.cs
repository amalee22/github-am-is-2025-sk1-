/*hlavní program - začátek*/

string again = "a";
while (again == "a")
{
    Console.Clear();

    //to-do vytvořit metodu razítko
razítko(); // metoda razítko - jde zpřehlednit program 


//načítání hodnot; - volání metody nactiCislo
ulong a = nactiCislo("Zadejte číslo a: ");
ulong b = nactiCislo("Zadejte číslo b: ");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
    Console.WriteLine();


}
 
/*hlavní program - konec*/

static void razítko() //void nic nebude vracet - metoda, která nic nevrací, ale může něco dělat
{
    Console.WriteLine("*********************************");
    Console.WriteLine("****** Výpočet NSD a NSN ********");   
    Console.WriteLine("*********************************");
    Console.WriteLine("******** Amálie Musilová ********");
    Console.WriteLine("*********************************");
}

//metoda pro načtení čísel
static ulong nactiCislo(string zprava) //metoda bude vracet ulong 
{
    Console.Write(zprava);
    ulong cislo;

    while (!ulong.TryParse(Console.ReadLine(), out cislo))  
    {
        Console.Write("Nezadali jste celé číslo. ");
    }

    //! METODA KTERÁ VRACÍ NĚJAKÝ DATOVÝ TYP, MUSÍ OBSAHOVAT NÁSLEDUJÍCÍ ŘÁDEK
    return cislo;
}