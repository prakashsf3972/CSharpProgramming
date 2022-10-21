using System;
namespace BinarySearching;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Size Of an Array : ");
        int size=int.Parse(Console.ReadLine());
        int[] elementsBox=new int[size];
        System.Console.WriteLine("Enter a Numbers : ");
        for(int i=0;i<size;i++)
        {
            elementsBox[i]=int.Parse(Console.ReadLine());
        }
        //int small=elementsBox[0];
        int temp=0;
        for(int i=0;i<size;i++)
        {
            for(int j=i+1;j<size;j++)
            {
                if(elementsBox[i]>elementsBox[j])
                {
                    temp=elementsBox[i];
                    elementsBox[i]=elementsBox[j];
                    elementsBox[j]=temp;
                }
            }
        }
       System.Console.WriteLine("SORTED ELEMENT ARE : ");
       for(int i=0;i<size;i++)
       {
        System.Console.WriteLine(elementsBox[i]);
       }
       //Binary Searching
       int startingIndex=0;
       int endingIndex=size-1;
       System.Console.WriteLine("Enter a Number to Search in Index : " );
       int search=int.Parse(Console.ReadLine());
       int mid=(startingIndex+endingIndex/2);
       string condition="true";
       while(startingIndex<endingIndex)
       {
            if(search==elementsBox[mid])
            {
                System.Console.WriteLine("The Searching Element is :"+mid);
                condition="false";
                break;
            }
            else if(search < elementsBox[mid])
            {
                endingIndex=mid-1;
            }
            else
            {
                startingIndex=mid+1;
            }
       }
       if(condition=="true")
       {
        System.Console.WriteLine("Search Element is Not Present "+search);
       }

    }
}
