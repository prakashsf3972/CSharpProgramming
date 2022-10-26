namespace RunTimePolymorphism
{
    public class Total : Sport
    {
        public int AcademiMark=100;
        public override void Display()
        {
            TotalMarks=AcademiMark+SportsMark;
            System.Console.WriteLine("Name :"+Name + "Mark :"+TotalMarks);
        }



    }
}