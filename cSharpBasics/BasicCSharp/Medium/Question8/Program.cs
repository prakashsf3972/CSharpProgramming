using System;
namespace Question8;
class program{
    public static void Main(string[] args)
    {
      
        System.Console.WriteLine("Enter a String");
        string input=Console.ReadLine();
        string even="";
        
        for(int i=0;i<input.Length;i++)
        {
            if((input[i]>=0)&&(input[i]<=9))
            {
                even+=input[i];
            }
        }
            int result=int.Parse(even);
            {
                    System.Console.WriteLine(result);
                    if(result%2==0)
                    {
                        System.Console.WriteLine("The Number is Even Number");
                    }
                    else{
                        System.Console.WriteLine("The Number is Odd Number");
                    }
            }
    
    }
}





