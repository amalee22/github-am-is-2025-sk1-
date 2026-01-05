
//name
using System.Net.Http.Headers;

var name = "Amy :3"; //string

//phone num
var number = "0292382981"; //aby se ukázala 0 před číslem, tak musíme použít string
                            //string
//age 
var age = 20;  //int

System.Console.WriteLine(name);
System.Console.WriteLine(number);
System.Console.WriteLine(age);




System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();

string miau = "i am eating a hamburger, and potato, EVERYDAY";
System.Console.WriteLine();
System.Console.WriteLine(miau);

System.Console.WriteLine();
string sybau = "shut your bitch ass up";
System.Console.WriteLine(sybau);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();





int x = 23, y = 11;

var remainder = (x % y); //int

System.Console.WriteLine(remainder);
 
x = 44;
remainder = x % y; //THIS IS REAS. -> WE DONT NEED INT ANYMORE
System.Console.WriteLine(remainder);



if(remainder%2==0) {
    System.Console.WriteLine("even");
    
}
else
{
    System.Console.WriteLine("odd");
}


Console.ReadLine();