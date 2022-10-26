using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Password: ");
        String Password=Console.ReadLine();
        if(Password=="s3cr3t!P@sswOrd")
        {
            System.Console.WriteLine("Welcome");
        }
        else{
            System.Console.WriteLine("Your Password is Wrong");
        }
    }
}
