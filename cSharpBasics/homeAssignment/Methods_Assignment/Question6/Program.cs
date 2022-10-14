using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number of factoroial: ");
        int facto=(int.Parse(Console.ReadLine()));
        int input=facto;
        facto=1;
        int initial=1;

        factorial1(facto,initial,input);



        void factorial1(int facto,int initial,int input)
        {

          while(initial<=input)  
          {
            facto=facto*initial;
            initial++;
          }
          System.Console.WriteLine($"The factorial of number {input} is {facto}");
        }
    }
}
