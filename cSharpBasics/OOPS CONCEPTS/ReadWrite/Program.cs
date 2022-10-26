using System;
namespace ReadWrite;
class Program
{
public static void Main(string[] args)
{
    System.Console.WriteLine("Enter your name");
    string myname = Console.ReadLine();
    System.Console.WriteLine("Enter your father name");
    string fathername = Console.ReadLine();
    //concatenation
    System.Console.WriteLine("my name is" +myname + "father's name is "+fathername);

    //Place holder
    System.Console.WriteLine("my name is:{0} and my father name is:{1}",myname,fathername);

    //interpolation
    System.Console.WriteLine($"my name is {myname} and my father name is {fathername}");
    Console.ReadLine();
    
}
}