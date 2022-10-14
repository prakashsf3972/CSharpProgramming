using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
      int sum=0,value;
      string statement;
      do
      {
        System.Console.WriteLine("Enter a Number:");
        value=(int.Parse(Console.ReadLine()));
        sum=sum+value;
        System.Console.WriteLine("Do you want to Continue : ");
        statement=Console.ReadLine().ToLower();
      }
      while((statement=="yes")&&(value>=0));
    System.Console.WriteLine($"The Output is {sum}");
    }
}
