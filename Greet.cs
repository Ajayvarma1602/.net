using System;
class Greet
{
 static void Main(){
 string name;
 Console.WriteLine("Enter your name : ");
 name=Console.ReadLine();
 Console.WriteLine($"Hello {name}"); 
}
}