using System;
namespace Question15;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Number : ");
        int number=int.Parse(Console.ReadLine());
        int count=0;
        for(int i=1;i<=number;i++)
        {
            if(number%i==0)
            {
                count++;
            }
        }
        if(count==2)
        {
            System.Console.WriteLine("The Given Number is a Prime Number ");
        }
        else{
            System.Console.WriteLine("The Given Number is Not a Prime Number");
        }
    }
}
