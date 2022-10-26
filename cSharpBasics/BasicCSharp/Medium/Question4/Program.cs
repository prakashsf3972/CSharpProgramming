using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter a initial Number: ");
       int starting=int.Parse(Console.ReadLine());
       System.Console.WriteLine("Enter a Final Number: ");
       int temp=0,sum=0,rem;
       int final=int.Parse(Console.ReadLine());
       System.Console.WriteLine("The Numbers are : ");
       {
            for(int initial=starting;initial<=final;initial++)
            {
                temp=initial;
                sum=0;
                while(temp!=0)
                {
                    rem=temp%10;
                    temp=temp/10;
                    sum=sum+(rem*rem*rem);
                }
                if(initial==sum)
                {
                    System.Console.WriteLine(initial);
                }
            }        
       } 
    }
}
