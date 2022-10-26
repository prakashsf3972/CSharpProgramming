using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a String: ");
        string name=Console.ReadLine();
        string duplicate=null;
        string modified=null;
        int i,j;
        for(i=0;i<name.Length;i++)
        {
            for(j=i+1;j<name.Length;j++)
            {
                if(name[i]==name[j])
                    {
                        duplicate+=name[j];
                    }
                
            }
        }
        
    }
}
