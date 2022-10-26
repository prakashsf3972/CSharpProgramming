using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Character:");
        char alphabet;
        bool check=(char.TryParse(Console.ReadLine(),out alphabet));
      if(check)
      {
        switch(alphabet)
        {
        case 'a':
        {
            System.Console.WriteLine("Enter character is in Vowel");
            break;
        }
         case 'e':
        {
            System.Console.WriteLine("Enter character is in Vowel");
            break;
        }
         case 'i':
        {
            System.Console.WriteLine("Enter character is in Vowel");
            break;
        }
         case 'o':
        {
            System.Console.WriteLine("Enter character is in Vowel");
            break;
        }
         case 'u':
        {
            System.Console.WriteLine("Enter character is in Vowel");
            break;
        }
        default:
        {
         System.Console.WriteLine("Enter character is not in vowel");
         break;
        }
        }
      }
     else{
            System.Console.WriteLine("Enter character is wrong");
        }
        
        
    }
}

