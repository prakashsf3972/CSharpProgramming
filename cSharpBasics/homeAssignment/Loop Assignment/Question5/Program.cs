using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
     int sum=0,count=0,odd;
     System.Console.WriteLine("Enter  number of Terms :");
     int nTerms=(int.Parse(Console.ReadLine()));
     System.Console.WriteLine("Enter a Initial value: ");
     int initial = (int.Parse(Console.ReadLine()));
     System.Console.WriteLine("Enter a End value : ");
     int end =(int.Parse(Console.ReadLine()));
     System.Console.WriteLine("The Odd Numbers are :");
     for(;initial<end;initial++)
     {
        if(count < nTerms)
        {
          if(initial % 2 == 0)
            {
              count++;
            }
            else
            {  
                odd = initial;
                System.Console.Write($"{odd}");
                sum=sum+initial;
            }
            end=end+count;
        }
     }
     System.Console.WriteLine($"Sum of odd numbers upto 10 Terms is {sum}");
  }
}
