using System;
namespace Interface;

  class Program{
    public static void Main(string[] args)
    {
        Square number=new Square(); //class Variable as Object
        number.Number=10;
        System.Console.WriteLine(number.Calculate());
        ICalculate value=new Square();//Interface variable as Object
        value.Number=20;
        System.Console.WriteLine(value.Calculate());
    }
  }  

