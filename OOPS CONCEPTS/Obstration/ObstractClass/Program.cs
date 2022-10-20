using System;
namespace ObstractClass;
class Program
{
    public static void Main(string[] args)
    {
        SyncFusion job1=new SyncFusion();
        job1.Name="Developer";
        job1.Salary(30);

        Tcs job2= new Tcs();
        job2.Name="Test Engineer";
        job2.Salary(15);
    }
}
