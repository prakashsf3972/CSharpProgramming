﻿using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the speeed:");
        double speed=(double.Parse(Console.ReadLine()));
        if(speed>0&&speed<=10)
        {
            System.Console.WriteLine("Slow");
        }
        else if(speed > 10&&speed <= 50)
        {
            System.Console.WriteLine("Average");
        }
        else if(speed>50&&speed<=150)
        {
            System.Console.WriteLine("Fast");
        }
        else if(speed>150&&speed<=1000)
        {
            System.Console.WriteLine("Ultra Speed");
        }
        else if(speed>1000)
        {
            System.Console.WriteLine("Extremly Fast");
        }
        else{
            System.Console.WriteLine("NO speed");
        }

    }
}