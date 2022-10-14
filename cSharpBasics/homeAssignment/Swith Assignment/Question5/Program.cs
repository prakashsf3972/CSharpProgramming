using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Choose your favourite Teams : \n 1.India \n2.Australia \n3.England");
        string choice=(Console.ReadLine());

        switch(choice)
        {
            case "India":{
            System.Console.WriteLine($"{choice} \n1.Dhoni \n2.jadeja \n3.Khozli ");
            break;
            }
            case "Australia":{
            System.Console.WriteLine($"{choice} \n1.smith \n2.khawaja \n3.zampa ");
            break;
            }
            case "England":{
            System.Console.WriteLine($"{choice} \n1.morgan \n2.moaen \n3.kevin");
            break;
            }
            default:
            {
                System.Console.WriteLine("Invalid Team");
                break;
            }
        }
    }
}