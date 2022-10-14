using System;
namespace Question11;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a input: ");
        string input=Console.ReadLine();
        string newString="";
        foreach(char value in input)
        {
            bool temp=newString.Contains(value);
            if(!temp)
            {
                newString=newString+value;
            }
        }
        System.Console.WriteLine(newString);
        /*for(int i=0;i<input.Length-1;i++)
        {
            for(int j=i+1;j<input.Length;j++)
            {
                if(input[i]==input[j])
                {
                    
                }
            }
        }*/
    }
}
