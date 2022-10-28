namespace BlackTicket
{
    public enum BookingStatus {Default,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID=7000;
        public string BookingID { get;  }
        public string UserID { get; set; }
        public string MovieID { get; set; }
        public string TheatreID { get; set; }
        public int SeatCount { get; set; }
        public double TotalAmount { get; set; }
        public BookingStatus Status { get; set; }

        public BookingDetails(string userID,string movieID,string theatreID,int seatCount,double totalAmount,BookingStatus status)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            UserID=userID;
            MovieID=movieID;
            TheatreID=theatreID;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            Status=status;
        }
        public BookingDetails()
        {

        }
        public BookingDetails(string data)
        {
            string[] value=data.Split(',');
            s_bookingID=int.Parse(value[0].Remove(0,3));
            BookingID=value[0];
            UserID=value[1];
            MovieID=value[2];
            TheatreID=value[3];
            SeatCount=int.Parse(value[4]);
            TotalAmount=double.Parse(value[5]);
            Status=BookingStatus.Parse<BookingStatus>(value[6],true);

        }
    }

}