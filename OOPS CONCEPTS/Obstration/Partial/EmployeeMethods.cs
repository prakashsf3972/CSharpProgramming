namespace Partial
{
    public partial class Employee
    {
       //Constructor
       //this refers to Constructor Name either we can Use 
       public Employee(int id,string name)
       {
        this.EmpID=id;
        this.Name=name;
       } 

      public void DisplayEmpInfo()
      {
        System.Console.WriteLine("EMployee ID: "+this.EmpID +"\t Employee Name:"+this.Name);
      }
    }
  
}