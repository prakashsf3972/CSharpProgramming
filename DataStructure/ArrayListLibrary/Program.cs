using System;
namespace ArrayListLibrary;
class Program
{
    public static void Main(string[] args)
    {
        ArrayList numberList1=new ArrayList();
        numberList1.Add(10);
        numberList1.Add(20);
        numberList1.Add("Prakash");
        numberList1.Add('s');
        numberList1.Add(120.224);
        ArrayList numberList2=new ArrayList();
        numberList2.Add(30);
        numberList2.Add("kannan");
        numberList1.AddRange(numberList2);

        numberList1.Insert(2,"Gowtham");

        numberList1.RemoveAt(2);

        numberList1.Remove("Prakash");


        foreach(dynamic value in numberList1)
        {
            System.Console.WriteLine("value is: "+value);
        }
        foreach(dynamic value1 in numberList2)
        {
            System.Console.WriteLine("2nd Value is: "+value1);
        }

    }
}