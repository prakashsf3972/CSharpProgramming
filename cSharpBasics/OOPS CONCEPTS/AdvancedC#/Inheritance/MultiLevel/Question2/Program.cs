using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        DepartmentDetails departMent=new DepartmentDetails("Mechanical","B.E");

        RackInfo rack=new RackInfo("Mechanical","B.E",10,2);

        BookInfo book=new BookInfo("Mechanical","B.E",10,2,"BharathiyarKavigal","Bharathiyar",40);
        book.Display();
    }
}
