using System;
namespace DictionaryDs;
class Program{
    public static void Main(string[] args)
    {
        Dictionary<long,string> phone=new Dictionary<long, string>();
        phone.Add(1234567890,"Prakash");
        phone.Add(1234567890,"Sam");
        phone.Add(2345678901,"Abi");
        phone.Add(5678901234,"Ajith");

        System.Console.WriteLine(phone[770747965]);

        bool result=phone.ContainsKey(1234567890);
        if(result)
        {
            System.Console.WriteLine("Contains Key Value");
        }
        else
        {
            System.Console.WriteLine("DoesNot Contain Key Value");
        }
        foreach(KeyValuePair<long,string> data in phone)
        {
            System.Console.WriteLine(data.Key+" "+data.Value);
        }
        phone[9842986818]="ManiKandan";

    }
}
