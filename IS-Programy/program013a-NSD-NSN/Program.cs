/*hlavní program - začátek*/

string again = "a";
while (again == "a")
{
    Console.Clear();

    //to-do vytvořit metodu razítko
razítko(); // metoda razítko - jde zpřehlednit program 



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

    again = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.



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