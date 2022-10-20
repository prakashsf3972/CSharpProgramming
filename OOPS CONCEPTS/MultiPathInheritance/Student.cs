namespace MultiPathInheritance
{
    public class Student : ISports , IAcademy
    {
        public int  AcadamiMark { get; set; }
        public string Name { get; set; }
        public int SportsMark { get; set; }


        public Student(string name,int acadamiMark,int sportsMark)
        {
            Name=name;
            AcadamiMark=acadamiMark;
            SportsMark=sportsMark;
        }
        public void showDetails()
        {
            System.Console.WriteLine($"Name :{Name}");
        }
    }
}