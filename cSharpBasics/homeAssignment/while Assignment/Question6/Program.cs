using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a initial value:");
        int initial=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a End Value:");
        int final=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Even numbers are: ");
        int original_initial=initial;
        int original_final=final;

        while(initial<=final)
        {
            if(initial %2 == 0)
            {
                System.Console.Write($"{initial} ");
            }
            initial++;
        }
        System.Console.WriteLine("\n Odd numbers are: ");
        initial=original_initial;
        final=original_final;
        while(initial<=final)
        {
        if(initial % 2 !=0)
        {
          System.Console.Write($"{initial} ");
        }
        initial++;
        }
        System.Console.WriteLine("\n Prime Numbers are: ");
        initial=original_initial;
        final=original_final;
        int divisible=1;
        int count=0;
        for(initial=initial;initial<=final;initial++)
        {
            if(divisible<=final)
            {
                if(initial%divisible==0)
                {
                   count++;
                }
            divisible++;
            }
            if(count==2)
            {
                System.Console.WriteLine($"{initial}");
                divisible=1;
                count=0;
            }
        }

    }
}