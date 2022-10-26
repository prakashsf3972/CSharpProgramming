using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter a no of terms: ");
       int terms=(int.Parse(Console.ReadLine()));
       int year=1;

    while(year<=terms)
    {
       if(year%4==0)
       {
        if(year%100==0)
        {
            if(year%400==0)
            {
                System.Console.WriteLine(+year);
                year++;
            }
            else
            {
              year++;  
            }
        }
        else{
            System.Console.WriteLine(+year);
            year++;
        }
       } 
       else
       {
        year++;
       }
    }
    }
}
