

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("********** úkol 10 - vlastní zadání ************");
    Console.WriteLine("************************************************");
    Console.WriteLine("************** Amálie Musilová *****************");
    Console.WriteLine("************************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n; //proměnná pro počet čísel n 

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    //DOLNÍ MEZ 
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }


    //HORNÍ MEZ 
    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
            
             // || upperbound < lowerbound - dvě čárky jsou OR - je to číslo nebo není číslo n  a zároveň je horní mez větší než dolní mez
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    // explaination: while the input is not an integer *OR* the upper bound is LESS THAN the lower bound
    {
        if (upperBound < lowerBound)
        {
            Console.Write($"horní mez musí být větší než dolní mez ({lowerBound}). Zadejte horní mez znovu: ");
        }
        else
        {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
        }
    }


    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine("Zadané hodnoty: "); //vypsání zadaných hodnot 
    Console.WriteLine($"Počet generovaných čísel: {n}; Dolní mez :{lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("======================================================");


int num1 = 5;
int num2 = 10;
int num3 = 15;


int[] numbers = new int[10];

/*
numbers[0]= Convert.ToInt32(Console.ReadLine());
numbers[1]= Convert.ToInt32(Console.ReadLine());
numbers[2]= Convert.ToInt32(Console.ReadLine());
numbers[3]= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{num1} {num2} {num3}");
System.Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]} {numbers[3]} ");
*/

for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write("enter a number:  ");
        System.Console.WriteLine();
        numbers[i] = Convert.ToInt32(Console.ReadLine());
 
    }

for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]} ");

    }





























System.Console.WriteLine();
System.Console.WriteLine();
 Console.WriteLine("Pro opakování programu stiskněte klávesu a.");


again = Console.ReadLine()?? "";

}

