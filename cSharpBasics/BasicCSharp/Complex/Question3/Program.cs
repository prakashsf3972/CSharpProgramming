using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a NameOne:");
        string name1=Console.ReadLine().ToLower();
        System.Console.WriteLine("Enter a Secondone: ");
        string name2=Console.ReadLine().ToLower();
        int count=0;
        if(name1.Length!=name2.Length)
        {
            System.Console.WriteLine("Two Strings are Not Anagrams");
        }
        if(name1.Length==name2.Length)
        {
                for(int i=0;i<name1.Length;i++)
                {
                    for(int j=0;j<name2.Length;j++)
                    {
                        if(name1[i]==name2[j])
                        {
                            count++;
                            break;
                        }
                    }
                }
        }        
        if(count==name1.Length)
        {
            System.Console.WriteLine("Output: Name one and two are Anagrams");
        }
        else
        {
            System.Console.WriteLine("Name One and Two are not Anagrams");
        }

    }
}
