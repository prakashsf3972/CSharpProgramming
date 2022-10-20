using System;
using System.IO;
using System.Collections.Generic;
namespace ListDs;
class Program{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder Created");
        }
        else
        {
           System.Console.WriteLine("Folder Found");
        }
        if(!File.Exists("TestFolder/Data.csv"))
        {
            System.Console.WriteLine("File doesn't exist.Creating a new CSV Files");
                File.Create("TestFolder/Data.csv");
        }
        else
        {
            System.Console.WriteLine("FileFound");
        }
        List<Student> vlist=new List<Student>();
        vlist.Add(new Student(){Name="Prakash",FatherName="Kannan",Gender=Gender.Male,DateOfBirth=new DateTime(2001,04,07)});
        vlist.Add(new Student(){Name="Gowtham",FatherName="Kannan",Gender=Gender.Male,DateOfBirth=new DateTime(1998,12,28)});
        vlist.Add(new Student(){Name="Suthish",FatherName="Kannan",Gender=Gender.Male,DateOfBirth=new DateTime(2003,04,07)});
        Insert(vlist);
        Display();

    }
    static void Insert(List<Student>vlist)
    {
        StreamWriter write=null;
        write=new StreamWriter(File.OpenWrite("Data.csv"));
        foreach(Student student in vlist)
        {
            write.WriteLine(student.Name+","+student.FatherName+","+student.Gender+","+student.DateOfBirth.ToString("dd/MM/yyyy"));
        }
        write.Close();
    }
    static void Display()
    {
        StreamReader reader=null;
        List<Student> listA=new List<Student>();
        if(File.Exists("TestFolder/Data.csv"))
        {
            reader=new StreamReader(File.OpenRead("TestFolder/Data.csv"));
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values =line.Split(',');
                if(values[0]!="")
                {
                    listA.Add(new Student(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DateOfBirth=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                }
            }
        }
         else
            {
                System.Console.WriteLine("File doesn't Exist");
            }
            reader.Close();
            foreach(var column1 in listA)
            {
                System.Console.WriteLine("Your Name :\t"+column1.Name+"\t Father Name"+column1.FatherName+"\t Gender is:"+column1.Gender+"\t DateOfBirth is :"+column1.DateOfBirth);
            }
    }
}
