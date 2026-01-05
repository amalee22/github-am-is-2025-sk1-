// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;




int x = 10, y = 20, z = 30;
 System.Console.WriteLine($"kokotů je {x}, kund je {y}, mrdek je {z}");
System.Console.WriteLine();


string textAge = "20";
int age = Convert.ToInt32(textAge);
Console.WriteLine(age);
 
System.Console.WriteLine();


string textBigNumba = "-10000000000000"; //už nemusí být L na konci - na definici long
 long BigNumba = Convert.ToInt64(textBigNumba);
 System.Console.WriteLine(BigNumba);

System.Console.WriteLine();

string textNegative = "-55,2";
double negative = Convert.ToDouble(textNegative);
System.Console.WriteLine(negative);

System.Console.WriteLine();

string textPrecision = "5,00001";
float precision = Convert.ToSingle(textPrecision); //OHHH A DEFINITION OF FLOAT IS SINGLE AND THATS WHY ITS SINCE IN THE CONVERT
System.Console.WriteLine(precision); //So , hover over pinky pink and it shows you what you write in the Convert.To-------

System.Console.WriteLine();

string textMoney = "14,99";
decimal money = Convert.ToDecimal(textMoney);
System.Console.WriteLine(money);

 System.Console.WriteLine();


//as. value - mění předešlé int 
 age = 50; //as integer 


Console.ReadLine();
 