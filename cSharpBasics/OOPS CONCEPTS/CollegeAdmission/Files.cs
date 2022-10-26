using System;
using System.IO;
namespace CollegeAdmission
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("College/StudentDetails.csv");
            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("College/DepartmentDetails.csv");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("College/AdmissionDetails.csv");
            }
        }
        public static void ReadFile()
        {
            string[] students=File.ReadAllLines("College/StudentDetails.csv");

            foreach(string data in students)
            {
                StudentDetails student=new StudentDetails(data);
                Operations.studentList.Add(student);
            }

            string[] departments=File.ReadAllLines("College/DepartmentDetails.csv");
            foreach(string data in departments)
            {
                DepartmentDetails department=new DepartmentDetails(data);
                Operations.departMentList.Add(department);
            }
            string[] admissions=File.ReadAllLines("College/DepartmentDetails.csv");
            foreach(string data in admissions)
            {
                AdmissionDetails admission=new AdmissionDetails(data);
                Operations.admissionList.Add(admission);
            }
        }

        public static void WriteToFiles()
        {
            string[] StudentDetails=new string [Operations.studentList.Count];
            for(int i=0;i<Operations.studentList.Count;i++)
            {
                StudentDetails[i]=Operations.studentList[i].RegisterId+","+Operations.studentList[i].StudentName+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].DateOfBirth.ToString("dd/MM/yyyy")+","+Operations.studentList[i].Gender+","+Operations.studentList[i].PhysicsMark+","+Operations.studentList[i].ChemistryMark+","+Operations.studentList[i].MathsMark;
            }

            File.WriteAllLines("College/StudentDetails.csv",StudentDetails);

            string[] DepartmentDetails=new string [Operations.departMentList.Count];
            for(int i=0;i<Operations.departMentList.Count;i++)
            {
               DepartmentDetails[i]=Operations.departMentList[i].DepartmentId+","+Operations.departMentList[i].DepartName+","+Operations.departMentList[i].NumberOfSeats;
            }

            File.WriteAllLines("College/DepartmentDetails.csv",DepartmentDetails);


            string[] AdmissionDetails=new string [Operations.departMentList.Count];
            for(int i=0;i<Operations.admissionList.Count;i++)
            {
               AdmissionDetails[i]=Operations.admissionList[i].AdmissionId+","+Operations.admissionList[i].StudentId+","+Operations.admissionList[i].DepartmentId+","+Operations.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy")+","+Operations.admissionList[i].AdmissionStatus;
            }

            File.WriteAllLines("College/AdmissionDetails.csv",AdmissionDetails);


        }
    }
}