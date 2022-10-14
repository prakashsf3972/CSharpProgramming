using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a String: ");
        string input=Console.ReadLine().ToLower();
        int vowels=0,consonant=0;
        foreach(char words in input)
        {
            if((words=='a')||(words=='e')||(words=='i')||(words=='o')||(words=='u'))
            {
                vowels++;
            }
            else if((words>='0')&&(words<='9'))
            {
                continue;
            }
            else if((words!='a')&&(words!='e')&&(words!='i')&&(words!='o')&&(words!='u'))
            {
                consonant++;
            }
        }
        System.Console.WriteLine("No of vowels "+vowels);
        System.Console.WriteLine("No of Consonant "+consonant);
    }
}
