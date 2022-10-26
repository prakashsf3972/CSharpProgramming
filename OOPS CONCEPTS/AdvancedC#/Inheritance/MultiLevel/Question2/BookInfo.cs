namespace Question2
{
    public class BookInfo:RackInfo
    {
        private static int s_bookID=1000;
        public string BookID { get; set; }
        public string  BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BookInfo(string departMentName,string degree,int rackNumber,int columnNumber,string bookName,string authorName,double price):base(departMentName,degree, rackNumber, columnNumber)
        {
            s_bookID++;
            BookID="BID"+s_bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void Display()
        {
            System.Console.WriteLine("DepartMentName:"+DepartMentName);
            System.Console.WriteLine("Degree: "+Degree);
            System.Console.WriteLine();
            System.Console.WriteLine("RackNumber:"+RackNumber);
            System.Console.WriteLine("ColumnNumber:"+ColumnNumber);
            System.Console.WriteLine();
            System.Console.WriteLine("BOOKID: "+BookID);
            System.Console.WriteLine("BOOKNAME:"+BookName);
            System.Console.WriteLine("AuthorName:"+AuthorName);
            System.Console.WriteLine("Price:"+Price);


        }


    }
}