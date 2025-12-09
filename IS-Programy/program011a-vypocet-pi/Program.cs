string again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("******** Výpočet PI ********");
    Console.WriteLine("****************************");
    Console.WriteLine("******** Tomáš Žižka *******");
    Console.WriteLine("****************************");
    Console.WriteLine();

    Console.Write("Zadejte přesnost (reálné číslo – čím menší, tím přesnější): ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost))
    {
        Console.Write("Nezadali jste reálné číslo, zkuste znovu: ");
    }

    // double i = 1;                 // první liché číslo
    
    double znamenko = 1;
    double piCtvrt = 1;    // první člen 1/1

    // Výpočet
    while ((1 / i) >= presnost)
    {
        i += 2;                 // další liché číslo
        znamenko = -znamenko;   // otočení znaménka
        piCtvrt += znamenko * (1 / i);

        string znak = (znamenko == 1) ? "+" : "-";
        Console.WriteLine($"Zlomek: {znak}1/{i}; aktuální hodnota PI = {4 * piCtvrt}");
    }

    Console.WriteLine($"\n\nHodnota čísla PI = {4 * piCtvrt}");
    //Console.WriteLine($"\n\nHodnota čísla PI = {4 * piCtvrt:f4}");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
