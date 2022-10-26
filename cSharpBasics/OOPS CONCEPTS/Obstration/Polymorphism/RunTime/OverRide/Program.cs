using System;
namespace OverRide;
class Program{
    public static void Main(string[] args)
    {
        Animal animal=new Animal();
        animal.Eat();

        Dog pet =new Dog();
        pet.Eat();

        Pomerian pet1=new Pomerian();
        pet1.Eat();
    }
}
