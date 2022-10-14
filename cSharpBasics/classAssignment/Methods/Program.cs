using System;
namespace Methods;
class Program{
    public static void Main(string[] args)
    {
        //METHODS WITH ARUGUMENT WITH RETURN TYPE
        int total=Addition(10,20);
        System.Console.WriteLine("the sum is"+total);



        int Addition(int num1,int num2)
        {
           int sum=num1+num2;
            return sum;
        }


//methods with arugument without return type
subtraction(10,20);



void subtraction(int num1,int num2)
{
    int difference;
    difference=num1+num2;
    System.Console.WriteLine("the subtraction"+difference);
}

//methods without argument with return type

int value =multiplication();
int multiplication()
{
    System.Console.WriteLine("Enter the number 1 value:");
    int number1=(int.Parse(Console.ReadLine()));
    System.Console.WriteLine("Enter the number2 value:");
    int number2=(int.Parse(Console.ReadLine()));
    int product=number1*number2;
    return product;
}
//methods without argument without return type

Division();

void Division()
{
    System.Console.WriteLine("enter a value 1");
    int number1=(Console.ReadLine());
    System.Console.WriteLine("enter a value2");
    int number2=(Console.ReadLine());
    int quotient=number1/number1;
    System.Console.WriteLine("Enter a number"+quotient);

}
    }
}
