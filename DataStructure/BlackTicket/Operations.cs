using System;
using System.Collections.Generic;
namespace BlackTicket
{
    public class Operations
    {
        //it add the total users in the list
        public static List<UserDetails> UsersList=new List<UserDetails>();
        //
        public static List<BookingDetails> bookingsList=new List<BookingDetails>();

        public static List <TheatreDetails> theatresList=new List<TheatreDetails>();

        public static List<MovieDetails> moviesList=new List<MovieDetails>();

        public static List<ScreeningDetails> screensList=new List<ScreeningDetails>();
        public static UserDetails loggedUser=null;
        public static void MainMenu()
        {
            string statement="yes";
            do{
            System.Console.WriteLine("****MAINMENU****");
            System.Console.WriteLine("_________________");
            System.Console.WriteLine("\t1.Registration\n\t2.Login\n\t3.Exit");
            System.Console.WriteLine("Enter your Choice: ");
            int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Called Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Login();
                        break;
                    }
                    case 3:
                    {
                        statement="no";
                        break;
                    }
                }
            }while(statement=="yes");
        }
        public static void Registration()
        {
            System.Console.WriteLine("***REGISTRATION***");
            System.Console.WriteLine("Enter your Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your PhoneNumber: ");
            long phoneNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Initial Balance: ");
            double walletBalance=double.Parse(Console.ReadLine());
            UserDetails user=new UserDetails(name,age,phoneNumber,walletBalance);
            UsersList.Add(user);
            System.Console.WriteLine("**Registration SuccessFull**");
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Your Registered ID is: "+user.UserID);
        }
        public static void Login()
        {
            System.Console.WriteLine("Called Login Page");
            System.Console.WriteLine("Enter your Registered ID: ");
            string userID=Console.ReadLine().ToUpper();
            int temp=0;
            foreach(UserDetails tempUser in UsersList)//it is used to traverse a userlist to find the userId
            {
                if(tempUser.UserID == userID)//if condition is true it enter to the submenu
                {
                    System.Console.WriteLine("UserID Found");
                    System.Console.WriteLine("------------");
                    loggedUser=tempUser;
                    temp=1;
                    SubMenu();
                }
            }
            if(temp==0)//condition is false it returns invalidid
            {
                System.Console.WriteLine("UserID is Invalid \n PLease Enter Invalid UserID");
            }
        }
        public static void DefaultUser()
        {
            UserDetails defaultUser1=new UserDetails("Ravichandran",30,8599488003,1000);
            UsersList.Add(defaultUser1);
            UserDetails defaultUser2=new UserDetails("Baskaran",30,1234567890,2000);
            UsersList.Add(defaultUser2);

        TheatreDetails theatre1=new TheatreDetails("Inox","AnnaNagar");
        theatresList.Add(theatre1);
        TheatreDetails theatre2=new TheatreDetails("Ega Theatre","Chetpet");
        theatresList.Add(theatre2);
        TheatreDetails theatre3=new TheatreDetails("Kamala","VadaPalani");
        theatresList.Add(theatre3);

        MovieDetails movie1=new MovieDetails("Bagubali 2","Telugu");
        moviesList.Add(movie1);
        MovieDetails movie2=new MovieDetails("Ponniyin Selvan","Tamil");
        moviesList.Add(movie2);
        MovieDetails movie3=new MovieDetails("Cobra","Tamil");
        moviesList.Add(movie3);
        MovieDetails movie4=new MovieDetails("Vikram","Tamil");
        moviesList.Add(movie4);
        MovieDetails movie5=new MovieDetails("vikram","Hindi(dubbed)");
        moviesList.Add(movie5);
        MovieDetails movie6=new MovieDetails("Beast","English");
        moviesList.Add(movie6);

        ScreeningDetails screen1=new ScreeningDetails(movie1.MovieID,theatre1.TheatreID,5,200);
        screensList.Add(screen1);
        ScreeningDetails screen2=new ScreeningDetails(movie2.MovieID,theatre1.TheatreID,2,200);
        screensList.Add(screen2);
        ScreeningDetails screen3=new ScreeningDetails(movie6.MovieID,theatre1.TheatreID,1,50);
        screensList.Add(screen3);
        ScreeningDetails screen4=new ScreeningDetails(movie1.MovieID,theatre2.TheatreID,11,400);
        screensList.Add(screen4);
        ScreeningDetails screen5=new ScreeningDetails(movie2.MovieID,theatre2.TheatreID,20,300);
        screensList.Add(screen5);
        ScreeningDetails screen6=new ScreeningDetails(movie4.MovieID,theatre2.TheatreID,2,500);
        screensList.Add(screen6);
        ScreeningDetails screen7=new ScreeningDetails(movie5.MovieID,theatre3.TheatreID,11,100);
        screensList.Add(screen7);
        ScreeningDetails screen8=new ScreeningDetails(movie2.MovieID,theatre3.TheatreID,20,200);
        screensList.Add(screen8);
        ScreeningDetails screen9=new ScreeningDetails(movie4.MovieID,theatre3.TheatreID,2,350);
        screensList.Add(screen9);

        BookingDetails booked1=new BookingDetails(defaultUser1.UserID,movie1.MovieID,theatre1.TheatreID,1,200,BookingStatus.Booked);
        bookingsList.Add(booked1);
        BookingDetails booked2=new BookingDetails(defaultUser1.UserID,movie4.MovieID,theatre2.TheatreID,1,400,BookingStatus.Booked);
        bookingsList.Add(booked2);
        BookingDetails booked3=new BookingDetails(defaultUser2.UserID,movie5.MovieID,theatre2.TheatreID,1,300,BookingStatus.Booked);
        bookingsList.Add(booked3);
        }
        public static void SubMenu()
        {
            string statement="yes";
            //Do while Loop is used to Repeat Submenu
            do
            {
            System.Console.WriteLine("***SUBMENU***");
            System.Console.WriteLine("\t1.TicketBooking\n\t2.Ticket Cancellation\n\t3.Booking HIstory\n\t4.Wallet Recharge\n\t5.Exit");
            System.Console.WriteLine("Enter your Choice: ");
            int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        //TicketBooking Method is Called when user Enter 1:
                        TicketBooking();
                        break;   
                    }
                    case 3:
                    {
                        //BookingHistory method is Called when user Enter 2:
                        BookingHistory();
                        break;
                    }
                    case 4:
                    {
                       //RechargeWallet method is used to Recharge a loggedInuser
                        RechargeWallet();
                        break;
                    }
                    case 5:
                    {
                        //when user Enter 5 it breaks the loop and its goto Mainmenu
                        statement="no";
                        break;
                    }
                }
            }while(statement=="yes");

        }
        public static void TicketBooking()
        {
            System.Console.WriteLine("***TICKET BOOKING***");
            System.Console.WriteLine("|THEATRE ID|\t|THEATRENAME|\t|THEATRELOCATION|");
            double totalAmount=0,amount=0;
            double tax=0;
            string statement="yes";
            int temp=0,temp1=0,availableseat=0;
                    foreach(TheatreDetails tempTheatre in theatresList)
                    {
                        System.Console.WriteLine($"{tempTheatre.TheatreID}\t\t{tempTheatre.TheatreName}\t\t{tempTheatre.TheatreLocation}");
                    }
                do
                {
                System.Console.WriteLine("Enter a Theatre ID to Find MoviesList in Theatre: ");
                string tempTheatreID=Console.ReadLine().ToUpper();
                System.Console.WriteLine("|MOVIEID|\t|MOVIENAME|\t|LANGAUGE|");
                foreach(TheatreDetails theatre in theatresList)
                {
                    if(theatre.TheatreID==tempTheatreID)
                    {
                        foreach(ScreeningDetails tempScreens in screensList)
                        {
                            if(tempScreens.TheatreID==tempTheatreID)
                            {
                                foreach(MovieDetails tempMovies in moviesList)
                                {
                                    if(tempScreens.MovieID==tempMovies.MovieID)
                                    {
                                        System.Console.WriteLine($"{tempMovies.MovieID}\t\t{tempMovies.MovieName}\t\t{tempMovies.Language}");
                                    }
                                
                                }
                            }
                        }
                            System.Console.WriteLine("Enter a MovieID to Book a Show: ");
                            string givenMovieID=Console.ReadLine().ToUpper();
                            System.Console.WriteLine("Enter a No.of.Seats to Book: ");
                            int count=int.Parse(Console.ReadLine());
                        foreach(ScreeningDetails tempScreens in screensList)
                        {
                            if(givenMovieID==tempScreens.MovieID && count<=tempScreens.NoOFSeatsAvailable)
                            {
                               System.Console.WriteLine("Seat is Available");
                               amount=count*tempScreens.TicketPrice;
                               tax=totalAmount/18;
                               totalAmount=amount + tax;
                               System.Console.WriteLine("Total Amount is: "+totalAmount);
                               temp1=1;
                            
                                if(totalAmount<=loggedUser.WalletBalance)
                                {
                                    loggedUser.Deduct(totalAmount);
                                    BookingDetails newBooking=new BookingDetails(loggedUser.UserID,givenMovieID,tempTheatreID,count,totalAmount,BookingStatus.Booked);
                                    bookingsList.Add(newBooking);
                                    System.Console.WriteLine("Your Booking ID is: "+newBooking.BookingID);
                                    System.Console.WriteLine("Booking Successfull");
                                }
                                else
                                {
                                    System.Console.WriteLine("InSufficient Balance");
                                }
                            }
                            else
                            {
                                temp1=0;
                                availableseat=tempScreens.NoOFSeatsAvailable;
                                break;
                            }   
                        }
                        if(temp1==0)
                        {
                            System.Console.WriteLine("Entered Seat is Not Available");
                            System.Console.WriteLine(" Availabale Seat is : "+availableseat);
                        }
                        
                           temp=1;
                           statement="no";
                           break;
                    }
                    else
                        {
                            temp=0;
                        }
                }
                    if(temp==0)
                    {
                        System.Console.WriteLine("Entered TheaterID is Invalid \n Please Enter Valid ID");
                        System.Console.WriteLine("Do you Want to Continue (yes/no): ");
                        statement=Console.ReadLine().ToLower();
                    } 
                }while(statement=="yes");
        }
        public static void BookingHistory()
        {
            System.Console.WriteLine("|BookingID|\t|UserID|\t|MovieID|\t|TheatreID|\t|SeatCount|\t|TotalAmount|\t|Booking Status|");
            foreach(BookingDetails tempbooked in bookingsList)
            {
                if(tempbooked.UserID==loggedUser.UserID)
                {
                    System.Console.WriteLine($"{tempbooked.BookingID}\t\t{tempbooked.UserID}\t\t{tempbooked.MovieID}\t\t{tempbooked.SeatCount}\t\t{tempbooked.TotalAmount}\t\t{tempbooked.Status}");
                }
            }   
        }
        public static void CancelOrder()
        {
            System.Console.WriteLine("Enter a BookingId you Want to Cancel: ");
            string cancelID=Console.ReadLine().ToUpper();
            foreach(BookingDetails tempBooked in bookingsList)
            {
                if(cancelID==tempBooked.BookingID && tempBooked.Status==BookingStatus.Booked)
                {
                    BookingHistory();
                }
            }
            string condition="yes";
            do{
            System.Console.WriteLine("Enter the BookingID ,you want to Cancel: ");
            string bookingID=Console.ReadLine().ToUpper();
            int temp=0;
            foreach(BookingDetails book in bookingsList)
            {
                if(bookingID==book.BookingID)
                {
                    System.Console.WriteLine("Available");
                    foreach(ScreeningDetails screen in screensList)
                    {
                        if(book.MovieID==screen.MovieID)
                        {
                            screen.NoOFSeatsAvailable+=book.SeatCount;
                            double addAmount=book.TotalAmount-20;
                            loggedUser.RechargeWallet(addAmount);
                            book.Status=BookingStatus.Cancelled;
                            System.Console.WriteLine("Ticket Cancelled SuccessFully");
                        }
                    }
                    temp=0;
                    condition="no";
                    break;
                }
                else{
                    temp=1;
                }
            }
            if(temp==1)
            {
                System.Console.WriteLine("---Invalid BookingID----");
                System.Console.WriteLine("Do you Want to Continue(yes/no): ");
                condition=Console.ReadLine().ToLower();
                
            }
            
            }while(condition=="yes");
        }
        public static void RechargeWallet()
        {
            System.Console.WriteLine("***RechargeWallet***");
            System.Console.WriteLine("Enter a Amount to Add in your Wallet: ");
            double addAmount=double.Parse(Console.ReadLine());
            loggedUser.RechargeWallet(addAmount);
            
        }
        
    }
    
}