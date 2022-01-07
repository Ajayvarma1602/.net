using System;
namespace ClassLibrary1
{
    public class Class1
    {
        public static void Main(){
        string str =Console.ReadLine(); 
        string reverse = "";
        int length = str.Length - 1; 

        while(length >= 0)
{
	 reverse += str[length];
      length--;
}

    Console.WriteLine(reverse);
            Console.ReadLine();
    }
}
}