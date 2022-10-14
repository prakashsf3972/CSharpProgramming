using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Your sugar Level");
        int sugar =(int.Parse(Console.ReadLine()));
        
        if((sugar >= 0) &&(sugar < 90))
        {
            System.Console.WriteLine("low sugar");
    
        }
        else if((sugar >= 90 ) && (sugar < 130))
        {
            System.Console.WriteLine("Normal");
        }
        else if((sugar >=130) && (sugar < 140))
        {
            System.Console.WriteLine("Medium");
        }
        else if((sugar >= 140) && (sugar < 170))
        {
            System.Console.WriteLine("High Sugar");
        }
        else if(sugar >= 170)
        {
            System.Console.WriteLine("You are a very high sugar Patient");
        }
        else
        {
            System.Console.WriteLine("Invalid Input");
        }

    }
}
