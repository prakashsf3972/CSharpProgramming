using System;
using System.Collections.Generic;
namespace FilterDeligate;

public delegate bool Filter(Person p);//our Delegate
class Program{
    public static void Main(string[] args)
    {
        Person person1=new Person(){Name="John",Age=41};
        Person person2=new Person(){Name="Jane",Age=30};
        Person person3=new Person(){Name="Ravi",Age=41};
        Person person4=new Person(){Name="Sam",Age=10};
        Person person5=new Person(){Name="Abi",Age=18};
        Person person6=new Person(){Name="Ajith",Age=25};
        //Create aList of Person Objects and fill it
        List<Person> people =new List<Person>(){person1,person2,person3,person3,person4,person5,person6};

        //Invoke Display People using Approcuiate Delegate
        DisplayPeople("Children",people,IsChild);
        DisplayPeople("Adults",people,IsAdult);
        DisplayPeople("Seniors",people,IsSenior);
        DisplayPeople("Voters",people,Isvoter);

        static void DisplayPeople(string title,List<Person> people,Filter filter)
        {
            System.Console.WriteLine("People in "+title+"List are: ");

            foreach(Person peoples in people)
            {
                if(filter(peoples))
                {
                    System.Console.WriteLine("{0} is {1} years Old",peoples.Name,peoples.Age);
                }
            }
        }
        static bool IsChild(Person peoples){return peoples.Age<15;}
        static bool Isvoter(Person peoples){return peoples.Age>=18;}
        static bool IsAdult(Person peoples){if(peoples.Age>=18&&peoples.Age>50) {return true;}else return false;}
        static bool IsSenior(Person peoples){return peoples.Age>=50;}
    }
}
