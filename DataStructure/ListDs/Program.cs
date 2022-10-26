using System;
namespace ListDs;
class Program
{
    public static void Main(string[] args)
    {
        List<int> numberList=new List<int>();
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);

        List<int>  numberList1=new List<int>();
        numberList1.Add(40);
        numberList1.Add(50);
        numberList.AddRange(numberList1);

        System.Console.WriteLine(numberList.Capacity);
        System.Console.WriteLine(numberList.Count);

        numberList.Insert(2,98);
        numberList.RemoveAt(2);

        foreach(int number in numberList)
        {
            System.Console.WriteLine("number are:"+number);
        }
        for(int i=0;i<numberList.Count;i++)
        {
            System.Console.WriteLine(numberList[i]);
        }
        

    }
}
