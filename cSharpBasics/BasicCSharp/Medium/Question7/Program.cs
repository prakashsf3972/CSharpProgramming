using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Starting Number: ");
        int start=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter No of Elements: ");
        int elements=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter a Number of Difference: ");
        int differnce=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("The number of Elemets are: ");
        int count=0,sum=0;
        while(start<=elements)
        {
            if(start%2!=0)
            {
                System.Console.WriteLine(start);
                sum+=start;
            }
            start++;
           
        }
        System.Console.WriteLine("The Sum of Elements are: ");
        System.Console.WriteLine(sum);
    }
}
