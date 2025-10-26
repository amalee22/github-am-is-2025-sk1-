string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("**** Vykreslení trojúhelníku ****");
    Console.WriteLine("********************************");
    Console.WriteLine("******** Amálie Musilová *******");
    Console.WriteLine("********************************");
    Console.WriteLine();

//výška trojúhelníku
    Console.Write("Zadejte výšku trojúhelníku (celé číslo): ");
    int height;

    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku znovu: ");
    }


    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(150));
        }
        Console.WriteLine();
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine() ?? "";
}