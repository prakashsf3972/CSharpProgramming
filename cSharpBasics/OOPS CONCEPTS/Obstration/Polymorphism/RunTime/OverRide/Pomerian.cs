namespace OverRide
{
    public class Pomerian:Dog
    {
        public new void Eat()//sealing overriding Method
        {
            System.Console.WriteLine("I am Pomerian");
        }
    }
}