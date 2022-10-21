using System;
namespace LinearSearching;
class Program{
    public static void Main(string[] args)
    {
        int[] numbers=new int[10];
        System.Console.WriteLine("Enter a Number: ");
        for(int i=0;i<numbers.Length;i++)
        {
            numbers[i]=int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Enter a Number to find in this Array : ");
        int findNumber=int.Parse(Console.ReadLine());
        int temp=0;
        for(int j=0;j<numbers.Length;j++)
        {
            if(numbers[j]==findNumber)
            {
                System.Console.WriteLine("Number is Present in the IndexList is :"+j);
                temp=1;
                break;
            }
        }
        if(temp==0)
        {
            System.Console.WriteLine("Number is Not Present in the List");
        }
    }
}