using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Number:");
        int integer=(int.Parse(Console.ReadLine()));
        int initial=1;
        int count=0;
        primenumber1(integer,initial);


        void primenumber1(int integer,int initial)
        {
            while(initial<=integer)
          {  
            if(integer%initial==0)
            {
                count++;
            }
            initial++;
          }
            if(count==2)
            {
                System.Console.WriteLine("The Given number is Prime number");
            }
            else{
                System.Console.WriteLine("The given number is not a prime number");
            }
        }
    }
}
