using System.IO;
namespace BlackTicket
{
    public class Files
    {
       public static void Create()
       {
        if(!Directory.Exists("BlackTicket"))
        {
            System.Console.WriteLine("Create Folder");
            Directory.CreateDirectory("BlackTicket");

        }
        if(!File.Exists("BlackTicket/UserDetails.csv"))
        {
            System.Console.WriteLine("Create File");
            File.Create("BlackTicket/UserDetails.csv");
        }
        if(!File.Exists("BlackTicket/TheatreDetails.csv"))
        {
            System.Console.WriteLine("Create File");
            File.Create("BlackTicket/TheatreDetails.csv");
        }
        if(!File.Exists("BlackTicket/MovieDetails.csv"))
        {
            System.Console.WriteLine("Create File");
            File.Create("BlackTicket/MovieDetails.csv");
        }
        if(!File.Exists("BlackTicket/ScreeningDetails.csv"))
        {
            System.Console.WriteLine("Create File");
            File.Create("BlackTicket/ScreeningDetails.csv");
        }
        if(!File.Exists("BlackTicket/BookingDetails.csv"))
        {
            System.Console.WriteLine("Create File");
            File.Create("BlackTicket/BookingDetails.csv");
        }
       }
       public static void ReadFile()
       {
            string[] users=File.ReadAllLines("BlackTicket/UserDetails.csv");
            {
                foreach(string data in users)
                {
                    UserDetails user=new UserDetails(data);
                    Operations.UsersList.Add(user);
                }
            }
            string[] theatres=File.ReadAllLines("BlackTicket/TheatreDetails.csv");
            {
                foreach(string data in users)
                {
                    TheatreDetails theatre=new TheatreDetails(data);
                    Operations.theatresList.Add(theatre);
                }
            }
            string[] movies=File.ReadAllLines("BlackTicket/MovieDetails.csv");
            {
                foreach(string data in users)
                {
                MovieDetails movie=new MovieDetails(data);
                    Operations.moviesList.Add(movie);
                }
            }
            string[] screens=File.ReadAllLines("BlackTicket/ScreeningDetails.csv");
            {
                foreach(string data in users)
                {
                ScreeningDetails screen=new ScreeningDetails(data);
                    Operations.screensList.Add(screen);
                }
            }
                string[] bookings=File.ReadAllLines("BlackTicket/BookingDetails.csv");
            {
                foreach(string data in users)
                {
                BookingDetails booked=new BookingDetails(data);
                    Operations.bookingsList.Add(booked);
                }
            }
       } 
       public static void WriteFile()
       {
           string[] userDetails=new string[Operations.UsersList.Count];
           for(int i=0;i<Operations.UsersList.Count;i++)
           {
              userDetails[i]=Operations.UsersList[i].UserID+","+Operations.UsersList[i].Name+","+Operations.UsersList[i].Age+","+Operations.UsersList[i].PhoneNumber+","+Operations.UsersList[i].WalletBalance;
           }
           File.WriteAllLines("BlackTicket/UsersDetails.csv",userDetails);

           string[] theatresDetails=new string[Operations.theatresList.Count];
           for(int i=0;i<Operations.theatresList.Count;i++)
           {
            theatresDetails[i]=Operations.theatresList[i].TheatreID+","+Operations.theatresList[i].TheatreName+","+Operations.theatresList[i].TheatreLocation;
           }
          File.WriteAllLines("BlackTicket/theatresDetails.csv",theatresDetails);

           string[] movieDetails=new string[Operations.bookingsList.Count];
           for(int i=0;i<Operations.moviesList.Count;i++)
           {
            movieDetails[i]=Operations.moviesList[i].MovieID+","+Operations.moviesList[i].MovieName+","+Operations.moviesList[i].Language;
           }
           File.WriteAllLines("BlackTicket/MoviesDetails.csv",movieDetails);

           string[]  screensDetails=new string[Operations.screensList.Count];
           for(int i=0;i<Operations.screensList.Count;i++)
           {
            screensDetails[i]=Operations.screensList[i].MovieID+","+Operations.screensList[i].TheatreID+","+Operations.screensList[i].NoOFSeatsAvailable+","+Operations.screensList[i].TicketPrice;
           }
            File.WriteAllLines("BlackTicket/screensDetails.csv",screensDetails);

            string[]  bookingDetails=new string[Operations.bookingsList.Count];
           for(int i=0;i<Operations.screensList.Count;i++)
           {
            bookingDetails[i]=Operations.bookingsList[i].BookingID+","+Operations.bookingsList[i].UserID+","+Operations.bookingsList[i].MovieID+","+Operations.screensList[i].TheatreID+","+Operations.bookingsList[i].SeatCount+","+Operations.bookingsList[i].TotalAmount+","+Operations.bookingsList[i].Status;
           }
           File.WriteAllLines("BlackTicket/ bookingDetails.csv", bookingDetails);
       }
    }
}