string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("******** výpočet čísla pí **********");
    Console.WriteLine("************************************");
    Console.WriteLine("********** Amálie Musilová *********");
    Console.WriteLine("************************************");
    Console.WriteLine();

    double pi = 0.0;

    // Vstup n
    Console.Write("Zadejte hodnotu (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }

    // Opravený cyklus – BEZ středníku!
    for (int k = 0; k < n; k++)
    {
        double term = Math.Pow(-1, k) / (2 * k + 1);
        pi += term;
    }

    pi = pi * 4;

    Console.WriteLine();
    Console.WriteLine($"Hodnota čísla pí je: {pi}");
    Console.WriteLine();

    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
#pragma warning disable CS8600
    again = Console.ReadLine();
#pragma warning restore CS8600
}
