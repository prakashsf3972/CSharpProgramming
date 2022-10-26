using System;
namespace QueueDs;
class Program
{
    public static void Main(string[] args)
    {
       Queue<string> myQueue=new Queue<string>();
       //creating a Queue
       myQueue.Enqueue("one");
       myQueue.Enqueue("two");
       myQueue.Enqueue("Three");
       myQueue.Enqueue("Four");
        String value1=myQueue.Peek();
        System.Console.WriteLine("Peek is "+value1);
        string value=myQueue.Dequeue();
        System.Console.WriteLine("Value is: "+value);
        bool value2=myQueue.Contains("one");
        System.Console.WriteLine(value2);
       
    }

}
