using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a String1: ");
        string name1=Console.ReadLine();
        System.Console.WriteLine("Enter a String2: ");
        string name2=Console.ReadLine();
        int count=0;
        string[] name1mo=name1.Split(new char[] {' '},StringSplitOptions.None );
        string[] name2mo=name2.Split(new char[] {' '},StringSplitOptions.None );
        for(int initial=0;initial<name1mo.Length;initial++)
        {
            for(int nextinitial=0;nextinitial<name2mo.Length;nextinitial++)
            {
                if(name1mo[initial]==name2mo[nextinitial])
                {
                    count++;
                }
            }
        }
        if(count==name1mo.Length)
        {
            System.Console.WriteLine("The Given strings Both are Equal");
        }
        else{
            System.Console.WriteLine("The Given strings are not equal");
        }
        
    }
}
