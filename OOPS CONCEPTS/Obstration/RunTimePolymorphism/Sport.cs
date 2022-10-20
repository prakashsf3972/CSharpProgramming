namespace RunTimePolymorphism
{
    public class Sport : Student
    {
        public int SportsMark =50;

        public override void Display()
        {
            System.Console.WriteLine("Name :"+Name + "Mark :"+SportsMark);
        }
    }
}