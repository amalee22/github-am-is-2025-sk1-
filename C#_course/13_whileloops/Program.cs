

/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


int i = 0; //var

while (i < 20) //our condition
{
    System.Console.WriteLine(i);
    i++; //POKUD JE PŘED CW TAK TO ZAČNĚ OD 1 , POKUD PO TAK TO ZAČNE OD 0

}
*/



Console.Write("Enter the first number:  ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number:  ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();


int actualAnswer = numberA * numberB;

Console.Write($"What's the value of {numberA} × {numberB}? ");

int answer = -1; // inicializace, aby while mohl fungovat

/*while (answer != actualAnswer)
{
    Console.Write("Enter your answer:  ");

    // přečteme vstup a převedeme na číslo
    answer = Convert.ToInt32(Console.ReadLine());

    if (answer != actualAnswer)
    {
        Console.WriteLine($"Dang it. Your answer {answer} is incorrect. Try again!");
        System.Console.WriteLine();
    }
}
*/

do
{
    Console.Write("Enter your answer:  ");

    // přečteme vstup a převedeme na číslo
    answer = Convert.ToInt32(Console.ReadLine());

    if (answer != actualAnswer)
    {
        Console.WriteLine($"Dang it. Your answer {answer} is incorrect. Try again!");
        System.Console.WriteLine();
    }
    
} while(answer != actualAnswer);



Console.WriteLine($"Well done! Your answer {answer} is correct!");
Console.ReadLine();