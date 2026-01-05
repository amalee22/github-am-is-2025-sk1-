
//TRYPARSE

bool success = true;

while(success)
{
    
System.Console.WriteLine("Enter a number    ");
string numInput = Console.ReadLine();
      //int num = Convert.ToInt32(Console.ReadLine());



if (int.TryParse(numInput, out int num))
{
    success = false;
    System.Console.WriteLine(num);
}
else
{
    System.Console.WriteLine("failed to convert");
}

}












Console.ReadLine();