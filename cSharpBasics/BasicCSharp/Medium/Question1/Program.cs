using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your basic Salary: ");
        double salary=(int.Parse(Console.ReadLine()));
        double hra,da,taxes=((6/100)*12),insurence=0.01*12,Total=0,tsalary=0;
        if((salary>=0)&&(salary<=10000))
        {
            hra=0.2;
            da=0.8;
            Total=salary+hra+da; 
            tsalary=(Total-taxes-insurence)*12;  
            System.Console.WriteLine("Total Salary is:"+Total);
            System.Console.WriteLine("Total annual salary is "+tsalary);
        }
        else if((salary>10000)&&(salary<=20000))
        {
            hra=0.25;
            da=0.95;
            Total=salary+hra+da;   
            tsalary=(Total-taxes-insurence)*12;
            System.Console.WriteLine("Total Salary is:"+Total);
            System.Console.WriteLine("Total annual salary is "+tsalary);
        }
        else if((salary>20000))
        {
            hra=0.3;
            da=0.95;
            Total=salary+hra+da;   
            tsalary=(Total-taxes-insurence)*12;
            System.Console.WriteLine("Total Salary is:"+Total);
            System.Console.WriteLine("Total annual salary is "+tsalary);
        }
    }
}
