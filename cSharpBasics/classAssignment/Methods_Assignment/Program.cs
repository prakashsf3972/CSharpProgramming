using System;
namespace Methods_Assignments;
class Program
{
    public static void Main(string[] args)

    {
        string choice;
    do{
        System.Console.WriteLine("Choose your Option Here: \n 1.Addition \n 2.Subtraction \n 3.Division \n 4.Multiplication");
        int option=(int.Parse(Console.ReadLine()));
    
        System.Console.WriteLine("Enter a integer 1 :");
        int integer1=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a integer 2: ");
        int integer2=(int.Parse(Console.ReadLine()));
        switch(option)
        {
        case 1:
                {
                int sum=Addition(integer1,integer2);
                System.Console.WriteLine($"The Sum of number is {sum}");
                break;
                }

        
        case 2:
                {
                int difference =Subtraction(integer1,integer2);
                System.Console.WriteLine($"The difference is :{difference}");
                break;
                }
        case 3:
                {
                int divisible=Difference(integer1,integer2);
                System.Console.WriteLine($"The division of number is:{divisible}");
                break;
                }

        
        case 4:
                {

                int multiple=Multiplication(integer1,integer2);
                System.Console.WriteLine($"The multiplication of number is:{multiple}");
                break;
                }

            }

           System.Console.WriteLine("Do you want to Continue:");
           choice=(Console.ReadLine());
        } while(choice =="yes");
   
           

            int Subtraction(int integer1,int integer2)
        {
            int total=integer1-integer2;
            return total;
        }

         int Addition(int integer1,int integer2)
        {
            int total=integer1+integer2;
            return total;
        }

        int  Multiplication(int integer1,int integer2)
        {
            int Total=(integer1*integer2);
            return Total;
        }
        
        int Difference(int integer1,int integer2)
        {
            int Total=(integer1/integer2);
            return Total;
        }
    }
    
    }

