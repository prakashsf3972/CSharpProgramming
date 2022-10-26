using System;
using System.Collections.Generic;
namespace StackDs;
class Program{
    public static void Main(string[] args)
    {
        Stack<string> myStack=new Stack<string>(4);

        Stack<int> myStack1=new Stack<int>();

        myStack.Push("one");
        myStack.Push("two");
        myStack.Push("three");
        myStack.Push("Four");

        string solution=myStack.Peek();
        System.Console.WriteLine("Peek Element is:"+solution);
        System.Console.WriteLine("POP Count is: "+myStack.Pop());
        bool value=myStack.Contains("two");
        System.Console.WriteLine("Contains "+value);


    }
}
