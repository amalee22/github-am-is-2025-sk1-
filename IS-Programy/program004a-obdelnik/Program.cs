using System.Numerics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("***** Vykreslení obdélníku *****");
    Console.WriteLine("********************************");
    Console.WriteLine("******* Amálie Musilová ********");
    Console.WriteLine("********************************");
    Console.WriteLine();

   
    Console.Write("Zadejte šířku obdélníku (celé číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku obdélníku znovu: ");
    }

Console.Write("Zadejte výšku obdélníku (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obdélníku znovu: ");
    }

    
i <= height
j <= height
i <= width
j <= width


//c:  
    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= width; j++)
          {
            Console.Write("*");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(150)); //zpoždění vykreslování
    }
        Console.WriteLine();
    }





    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    again = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

}



