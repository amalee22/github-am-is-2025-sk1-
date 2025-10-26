string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("**** Vykreslení obrazce 20 ****");
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

    // rozdělení bloků
    int blockSize = 2;  
    // velikost každého bloku hvězdiček 

for (int i = 0; i < size; i++)
{
        for (int j = 0; j < size; j++)
        {
            // jaký 2x2 blok to je
            int blockRow = i / blockSize;
            int blockCol = j / blockSize;

            // pokud je suma sudá, vykresli hvězdičku
            if ((blockRow + blockCol) % 2 == 0)
                Console.Write("* ");
            else
                Console.Write("  "); // tohle je jen pro mezery v šachovnici
        }
    System.Threading.Thread.Sleep(50);
    Console.WriteLine();
}

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine() ?? "";
}