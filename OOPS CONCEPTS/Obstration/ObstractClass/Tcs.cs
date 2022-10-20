namespace ObstractClass
{
    public class Tcs :Employee
    {
        public override string Name { get {return name;} set {name=value;} }
        //Abstract Method Definition
        public override void Salary(int dates)
        {
            Display();//Calling abstract Base Class's normal method 
            Amount=(double)dates*500;
            System.Console.WriteLine(Amount);
        }        
    }
}