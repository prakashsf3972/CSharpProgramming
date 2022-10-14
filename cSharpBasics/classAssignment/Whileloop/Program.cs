using System;
namespace Whileloop;
class Program{
    public static void Main(string[] args)
    {
        int number=0;
          System.Console.WriteLine("The odd numbers are : ");
         while(number<=25)
        {
         if(number%2!=0)
         {
            System.Console.WriteLine($"{number}");
            number++;
         }  
        }
        int integer1;
        System.Console.WriteLine("Enter your Number : ");
        bool input=int.TryParse(Console.ReadLine(), out integer1);
        
       
        while(!input)
        {
            System.Console.WriteLine("Enter your Valid Input :");
            integer1=(int.Parse(Console.ReadLine()));

        }
        System.Console.WriteLine("Entered value is Correct:" + integer1);


    }
}
