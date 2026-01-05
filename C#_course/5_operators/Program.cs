// See https://aka.ms/new-console-template for more information

//OPERATORS +, -,  × -> *,  ÷ -> / 


//int age = 20;
//here its better to use double than int - > doesnt leave out 0.x 
double age = 27.3;


//age++; //adding 1 to a variable  - ONLY 1
// age = age + 1; value of itself plus something to the var. - POSSIBILITY OF ADDING ANYTHING... -> age = age + 22; etc
// age += 22; //does the same  ^ - also can add anything, not just 1 


//* a / 
//age *= 10;
age /= 2;

Console.WriteLine(age);

age--;
System.Console.WriteLine(age); 


//STRING VARIABLE
string name = "Amy";
name += " is programming :3";
//name -= " is programming :3"; - > NEJDE - CANT REMOVE FROM A STRING 
System.Console.WriteLine(name);


char a = 'a';
a += 'm';
//get UNICODE VALUES TGT AND TRY TO ADD THOSE TGT - NOT THE CHARS THEMSELVES 
System.Console.WriteLine(a);

 System.Console.WriteLine();

int i = 0;
System.Console.WriteLine(++i); //++ action first and then do i - > return to action i
System.Console.WriteLine(i);








Console.ReadLine();
