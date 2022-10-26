using System;
namespace ByType;
class Program{
   
   public static void Main(string[] args)
   {
    Display(100);
    Display("Prakash");
   }
   static void Display(string name)
   {
    System.Console.WriteLine("Name"+name);
   }
   static void Display(int number)
   {
    System.Console.WriteLine("number"+number);
   }
}
