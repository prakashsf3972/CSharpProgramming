using System;
namespace DoWhile;
class Program{
    public static void Main(string[] args)
    {
    string statement;
    do
    {
        System.Console.WriteLine("Do you Hungry :");
        statement=(Console.ReadLine());
    }
    while(statement == "yes")
    {
        System.Console.WriteLine("eat food");
    }
}
}
