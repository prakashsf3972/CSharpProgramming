using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Number1:");
        int Value1=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Eneter a NUmber2:");
        int value2=(int.Parse(Console.ReadLine()));
        
        int Total=Addition(Value1,value2);
        System.Console.WriteLine("Addition :"+Total);

        int Total2=Subtraction(Value1,value2);
        System.Console.WriteLine("Subtraction :"+Total2);

        int Total3=Division(Value1,value2);
        System.Console.WriteLine("Division:"+Total3);

        int Total4=Multiplication(Value1,value2);
        System.Console.WriteLine("Multiplication:"+Total4);

    int Addition(int value1,int value2)
    {
        int sum=value1+value2;
        return(sum);
    }
     int Subtraction(int value1,int value2)
    {
        int difference=value1-value2;
        return(difference);
    }
    int Division(int value1,int value2)
    {
        int sum=value1/value2;
        return(sum);
    }
    int Multiplication(int value1,int value2)
    {
        int sum=value1*value2;
        return(sum);
    }
}
}
