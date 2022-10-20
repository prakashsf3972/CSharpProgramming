namespace ObstractClass
{
    public abstract class Employee
    {
      protected string name; //normalField
      public abstract string Name {get;set;}//Abstarct Property
      public double Amount { get; set; }  //Normal Property
      public void Display(){System.Console.WriteLine(name);}//Normal Method
      public abstract void Salary(int dates);//Abtract method
    }
}