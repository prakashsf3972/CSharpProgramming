using System;
namespace RunTimePolymorphism;
internal class Program{
    public static void Main(string[] args)
    {
        Total total=new Total();
        Student student;
        student=total;//Pass Total Class Object refernce

        student.Name="Prakash";
        //student.StudentName="Mani";//cannot pass value to children reference

        student.Display();

        Sport sport=new Sport();
        student=sport;//pass Sports class object refernce
        student.Name="Kannan";
        student.Display();

    }
}
