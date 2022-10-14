using System;
namespace DoWhile;
class Program{
    public static void Main(string[] args)
    {
     int number;
     string statement;
     do
     {
        System.Console.WriteLine("Enter your Number :");
        number =(int.Parse(Console.ReadLine()));

          if(number%2==0)
       {
        System.Console.WriteLine("The Given number is Even");
       }
       else
       {
        System.Console.WriteLine("The given number is Odd");
       }

       System.Console.WriteLine("do you want to Continue : "); 
      statement=Console.ReadLine().ToLower();

    while(statement!="yes"&&statement!="no")
    {
        System.Console.WriteLine("Enter a valid input");
       statement=Console.ReadLine().ToLower();
    }

      
    }while(statement=="yes");
       
}
}

