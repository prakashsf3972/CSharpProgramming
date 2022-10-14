using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a String:");
        string input=Console.ReadLine().ToLower();
        int alphabet=0,digit=0,specialchar=0;
        
        foreach(char words in input)
        {
            if((words>='a')&&(words<='z'))
            {
                alphabet++;
            }
            else if((words>='0')&&(words<='9'))
            {
                digit++;
            }
            else
            {
                specialchar++;
            }
        }
        System.Console.WriteLine("The Count of Alphabet is: "+alphabet);
        System.Console.WriteLine("The Count of digit is: "+digit);
        System.Console.WriteLine("The Count of Specialchar is: "+specialchar);
    }
}
