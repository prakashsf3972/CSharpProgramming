namespace OnlineLibrary
{
    public class BookInfo:DepartmentDetails
    {
        private static int s_bookID=100;
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BookInfo(string departMentName,string degree,string bookName,string authorName,double price):base(departMentName,degree)
        {
            s_bookID++;
            BookID="BID"+s_bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }

        public void Display()
        {
            ShowDetails();
            System.Console.WriteLine("BookName:"+BookName);
            System.Console.WriteLine("AuthorName:"+AuthorName);
            System.Console.WriteLine("Price: "+Price);
        }
    }
}