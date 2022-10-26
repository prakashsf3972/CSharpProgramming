using System;
namespace OnlineLibrary;
class Program{
    public static void Main(string[] args)
    {
        DepartmentDetails department=new DepartmentDetails("Mechanical","B.E");
        department.ShowDetails();

        BookInfo book=new BookInfo(department.DepartMentName,department.Degree,"StoryPoint","RAJA",50);
        book.Display();
    }
}
