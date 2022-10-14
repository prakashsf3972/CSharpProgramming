using System;
namespace Array_Assignment;
class Program{
    public static void Main(string[] args)
    {
        
        string[] names= new string[5];
        int repeated=0;
        System.Console.WriteLine("Enter a name:");
        for(int index=0;index<5;index++)
        {
            
         names[index]=(Console.ReadLine());
        }
        for(int index=0;index < 5;index++)
        {
            System.Console.WriteLine("Names are :");
            System.Console.WriteLine(names[index]);
        }
        System.Console.WriteLine("Enter a name you want:");
        string repeat=(Console.ReadLine());
        for(int index=0;index < 5; index++)
        {       
            if(repeat==names[index])
            {
                System.Console.WriteLine($"The name stored in index :{index}");
                repeated++;
            }
        }
        if(repeated == 1)
        {
         System.Console.WriteLine("The Name is Present in Array");
        }
        else{
            System.Console.WriteLine("The name is Not Present in Array");
        }
          
           repeated=0;
           System.Console.WriteLine("USING FOREACH");
           foreach(string name in names)
            {
                if(repeat==name)
                {
                    repeated++;
                } 
            }

             if(repeated == 1)
        {
         System.Console.WriteLine("The Name is Present in Array");
        }
        else{
            System.Console.WriteLine("The name is Not Present in Array");
        }   
    }
}
