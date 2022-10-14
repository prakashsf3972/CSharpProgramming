using System;
namespace Question10;
class Project{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input a username: ");
        string username=Console.ReadLine();
        System.Console.WriteLine("Input a password: ");
        string password=Console.ReadLine();
        if((username=="user")&&(password=="pass"))
        {
            System.Console.WriteLine("Password is Correct");
        }
    }
}
