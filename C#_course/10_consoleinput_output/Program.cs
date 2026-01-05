
using System.Dynamic;


/*
System.Console.Write("Enter your name: ");


string name = Console.ReadLine(); //itll store the typed in name as a string
//System.Console.WriteLine(name);
System.Console.WriteLine();




Console.Write("Enter your age:  ");

//System.Console.WriteLine(age);

int age = Convert.ToInt32(Console.ReadLine());
//string ageInput = Console.ReadLine();
//int age = Convert.ToInt32(ageInput); 





if (age < 0 || age > 150)
{
    System.Console.WriteLine("Invalid age!!! you shall face the wrath of The Goddess (storm reference)");
    System.Environment.Exit(0);
}
else
{
   //== eq to    >   >=    <    <=   !=not eq to 
if (age >=18 && age < 69)
{
    System.Console.WriteLine("You are a pookie :333");
}
else if(name == "Cristian")
{
    System.Console.WriteLine($"You are extremely stinky, {name}");
}

else if(age == 69)
{
    System.Console.WriteLine($"You are a legend, {name}");
}
else if(age > 69)
{
    System.Console.WriteLine($"You are ancient, {name}");
}
else if(age < 18)
{
    System.Console.WriteLine($"You are a whipper snapper, {name}");
}
}




Console.Write($"Your name is {name} and your age is {age}");




Console.ReadLine();
Console.ReadLine(); //anything you write returns as a STRING 

*/
Console.Write("Enter the first number:  ");
int numberA = Convert.ToInt32(Console.ReadLine());
 
Console.Write("Enter the second number:  ");
int numberB = Convert.ToInt32(Console.ReadLine());
 
int actualAnswer = numberA * numberB;

Console.Write("value of " + numberA + "x" + numberB + ": ");
string answerInput = Console.ReadLine();
int answer = Convert.ToInt32(answerInput);


if(answer == actualAnswer)  // single = is for assignment double == is for equality yay
{
    System.Console.WriteLine($"Congrats! Your answer {actualAnswer} is correct");
}
else if(answer != actualAnswer) //not eq to eachother - not needed - its a given 
{
    System.Console.WriteLine($"Dang it. Your answer {answer} is incorrect. {actualAnswer} is correct :(");
}

Console.ReadLine();