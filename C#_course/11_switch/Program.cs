

using System.Runtime.CompilerServices;

Console.Write("Enter a day of the week:  ");
int day = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(day);

/*if(day == 1)
{
    System.Console.WriteLine("Its monday bitch");
}
else if(day == 2)
{
    System.Console.WriteLine("Its tuesday innit");
}
else if(day == 3)
{
    System.Console.WriteLine("Its wednesday, just gotta make it to friday ");    
}
else if(day == 4)
{
    System.Console.WriteLine("Its thursday stinker");
}
else if(day == 5)
{
    System.Console.WriteLine("IT IS FRIDAY LETS GO");
}
else if(day == 6)
{
    System.Console.WriteLine("LETS GO SATURDAY, LETS FUCKING GO");
}
else if(day == 7)
{
    System.Console.WriteLine("....omfg.......tomorrow...is monday.......no.. the pain and suffering awaiting...");
}
*/

switch (day)
{
    case 1 : System.Console.WriteLine("mon");
        break;
    case 2 : System.Console.WriteLine("tue"); 
        break;
    case 3 : System.Console.WriteLine("wed");    
        break;
    case 4 : System.Console.WriteLine("thu");   
        break; 
    case 5 : System.Console.WriteLine("FRIDAY HOESS LETS GO");
        break;
    case 6 : System.Console.WriteLine("sat");
        break;
    case 7 : System.Console.WriteLine("sun");
        break;

            default: System.Console.WriteLine("what you wrote is invalid hoe, just like your opinions :), enter a value between 1 and 7");
                break;
}









Console.ReadLine();
