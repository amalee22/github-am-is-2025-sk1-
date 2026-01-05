using System.Globalization;
using System.Runtime.CompilerServices;

string opakovani = "a";
    while (opakovani == "a")
    {

     //number input
    /*
      Console.Write("Enter the first number:  ");
      int numberA = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the second number:  ");
      int numberB = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the third number:  ");
      int numberC = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the fourth number:  ");
      int numberD = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the fifth number:  ");
      int numberE = Convert.ToInt32(Console.ReadLine());
    */

      Console.WriteLine("Enter five numbers between -1000 and 2222:  ");




          for(int i = 0; i <= 5; i++) // arrays also start from 0 - first num in array starts at 0 
        {

        Console.WriteLine($"Enter number {i}:   ");
        int number = Convert.ToInt32(Console.ReadLine());


if( number < -1000 || number > 2222)
        {
             System.Console.WriteLine("YOU DIDNT PUT IN A VALID NUMBER BETWEEN -1000 AND 2222 ........ ENTER A NEW NUMBER");
        }

        if (number % 3 == 0 && number % 5 == 0)
        {
        Console.WriteLine($"{number} is divisible by both 3 and 5!!!");
        }
         else if (number % 3 ==0 )//only by 3
        {
        Console.WriteLine($"{number} is divisible by 3 only :(");
        }
        else if (number % 5 == 0) //only by 5
        {
        Console.WriteLine($"{number} is divisible by 5 only :(");
        }
        else if (number % 3 != 0 && number % 5 !=0)
         {
         Console.WriteLine($"{number} is not divisible by both 3 and 5 :O");
         }


        }

      Console.WriteLine("Enter 'a' to repeat the programme");
      opakovani = Console.ReadLine();
      }





      Console.ReadLine();