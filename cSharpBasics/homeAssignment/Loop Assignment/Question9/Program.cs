using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number : ");
        int number=(int.Parse(Console.ReadLine()));
        int original = number;
        int temp=0,count=0;
        double cubes=0,sumofcubes=0;
        
        for(int initi=1; initi<=number;initi++)
        {
            if(initi == number)
            {
            number=number/10;
            count++;
            initi=0;
            }
        }
        number=original;
        for(int initial=1; initial<=number;initial++)
        {
            if(initial == number)
            {
            temp=(number%10);
            cubes = Math.Pow(temp,count);
            sumofcubes=sumofcubes+cubes;
            number=number/10;
            initial=0;
            }
        }
        System.Console.WriteLine($"{sumofcubes}");
        if(sumofcubes == original)
        {
            System.Console.WriteLine("The Given number is a Armstrong number");
        }
        else
        {
            System.Console.WriteLine("The Given number is not a Armstromg number");
        }
        
    }
}
