namespace BlackTicket
{
    public class ScreeningDetails
    {
        public string MovieID { get; set; }
        public string TheatreID { get; set; }
        public int NoOFSeatsAvailable { get; set; }

        public double TicketPrice { get; set; }

        public ScreeningDetails()
        {
            
        }

        public ScreeningDetails(string movieID,string theatreID,int noOFSeatsAvailable,double ticketPrice)
        {
            MovieID=movieID;
            TheatreID=theatreID;
            NoOFSeatsAvailable=noOFSeatsAvailable;
            TicketPrice=ticketPrice;
        }
           public ScreeningDetails(string data)
        {
            string[] values=data.Split(',');
            MovieID=values[0];
            TheatreID=values[1];
            NoOFSeatsAvailable=int.Parse(values[2]);
            TicketPrice=double.Parse(values[3]);
        }
    }
}