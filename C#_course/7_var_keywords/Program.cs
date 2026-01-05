// See https://aka.ms/new-console-template for more information
using System;

int x = 10, y = 20, z = 30;

System.Console.WriteLine($"mám {x} koček, {y} psů a {z} papoušků");



//int age = 20;
//VAR KEYWORD 

var age = 23;   //musíme mu dát hodnotu - compileru
Console.WriteLine(age);
 
    System.Console.WriteLine(int.MaxValue);
    System.Console.WriteLine(int.MinValue);


 var bigNumba = 10000L;  //najednou řekně, že jsou oba v 64 - > MUSÍME DÁT L NA KONEC
 System.Console.WriteLine(bigNumba);

     System.Console.WriteLine(long.MaxValue);
    System.Console.WriteLine(long.MinValue);

var negative = -55.2D;
System.Console.WriteLine(negative);
System.Console.WriteLine(double.MaxValue);
System.Console.WriteLine(double.MinValue);

var precision = 5.00001F;
System.Console.WriteLine(precision);
System.Console.WriteLine(float.MaxValue);
System.Console.WriteLine(float.MinValue);

var money = 14.99M;
System.Console.WriteLine(money);
System.Console.WriteLine(decimal.MinValue);
System.Console.WriteLine(decimal.MaxValue);
 
//as. value - mění předešlé int 
 age = 50; 





 //STEJNÉ PRO STRING - VAR

 var name = "Amy"; //recog. string and char
 var letter = 'a';
System.Console.WriteLine(name);
System.Console.WriteLine(letter);

Console.ReadLine();
 