using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Your Password : ");
        string password = (Console.ReadLine());
        
        if (password == "HiTeam")
        {
            System.Console.WriteLine("PASSWORD IS CORRECT");
        }
        else{
            System.Console.WriteLine("PASSWORD IS INCORRECT");
        }
    }
}
