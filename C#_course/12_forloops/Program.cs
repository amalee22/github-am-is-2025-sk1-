




System.Console.Write("What do you want to say? express? share?");
string message = Console.ReadLine();

System.Console.Write("HOW MANY TIMES DO YOU WANT TO REPEAT IT:  ");
int loopCounter = Convert.ToInt32(Console.ReadLine());

if(loopCounter <= 0)
{
    System.Console.WriteLine("YOU DIDNT PUT IN A VALID VALUE........ ENTER A VALUE ABOVE 0");
}
else //>= 1
{
    System.Console.WriteLine();


for (int i = 0; i < loopCounter; i++)
// i+= 2 atd. , ALE NORMÁLNĚ SE POUŽÍVÝ i++ 
{
    System.Console.WriteLine(message);
}
 
 System.Console.WriteLine( );
for(int i = 0; i < loopCounter; i += 2) //GOES UP BY 2
{
    System.Console.WriteLine(i);
}
}






Console.ReadLine();