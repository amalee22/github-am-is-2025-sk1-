string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("***** Vykreslení obrazce 3 *****");
    Console.WriteLine("********************************");
    Console.WriteLine("******** Amálie Musilová *******");
    Console.WriteLine("********************************");
    Console.WriteLine();

    Console.Write("Zadejte výšku obrazce (celé číslo): ");
    int size;

    while (!int.TryParse(Console.ReadLine(), out size))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku znovu: ");
    }


    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (i == 0 || i == size - 1 || j == 0 || j == size - 1 || i == j || i + j == size - 1)
                Console.Write("* ");
            else
                Console.Write("  ");
        }
        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));
        Console.WriteLine();
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine() ?? "";
}
