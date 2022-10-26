using System;
namespace enumTypes;
class Program{
    public enum Gender {Default,Male,Female,TransGender}
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Select Gender Options Male,Female,Transgender");
        Gender gender1=Enum.Parse<Gender>(Console.ReadLine().ToUpper(),true);//true ignores case
        System.Console.WriteLine(gender1);

        //Select by string or integer
         System.Console.WriteLine("Select Gender Options Male,Female,Transgender");
        // Gender gender2=Gender.Default;
        bool temp=Enum.TryParse<Gender>(Console.ReadLine().ToUpper(),true,out Gender gender2);//true will ignore 
        while(!temp||((int)gender1<4 && (int)gender2>0))
        System.Console.WriteLine(gender1);
        {
            System.Console.WriteLine("Invalid Gender \n Enter again");
            temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
        }
        System.Console.WriteLine(gender2);
    }
}
