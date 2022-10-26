namespace OverRide
{
    public class Dog : Animal//derived class of animal
    {
        public override void Eat()//overriding method from Animal
        {
            System.Console.WriteLine("Ate Food");
        }
    }
}