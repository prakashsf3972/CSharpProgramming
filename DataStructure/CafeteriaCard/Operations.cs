using System;
namespace CafeteriaCard
{
    
    public delegate void EventManager();
    public partial class Operations
    {
        public static List<UserDetails> usersList=new List<UserDetails>();
        public static List<FoodDetails> foodsList=new List<FoodDetails>();
        public static List<OrderDetails> ordersList=new List<OrderDetails>();
        public static List<CartItem> itemsList=new List<CartItem>();
        public static UserDetails loggedUser=null;
          //SHOWING MAINMENU METHOD TO VIEW USER

        public static event EventManager eventlink=null;
        /// <summary>
        /// Method Subscribe is used to subcribe method to the deligate
        /// </summary>
        private static void subscribe()
        {
            eventlink+=new EventManager(Files.Create);
            eventlink+=new EventManager(Files.ReadFile);
            eventlink+=new EventManager(DefaultUser);
            eventlink+=new EventManager(MainMenu);
            eventlink+=new EventManager(Files.WriteFile);
        }
        /// <summary>
        /// Method HandleEvent  is used trigger the Event
        /// </summary>
        public static void HandleEvent()
        {
            subscribe();
            eventlink();
        }
        /// <summary>
        /// Mainmenu method is used to show the Mainmenu page to the user
        /// </summary>
          public static void MainMenu()
          {
            //ITS CONTINUES SHOW MAINMENU WHEN CONDITION IN YES
            string statement="yes";
            // DO WHILE LOOP IS USED TO SHOW REPEATLY MAINMENU METHOD WHEN USER WANTS TO REGISTER OR LOGIN OR EXIT
            do
            {
            //MAINMENU METHOD IS CALLED
            System.Console.WriteLine("***MAIN MENU***");
            System.Console.WriteLine("----------------");
            //SHOWING MAINMENU OPTIONS IN SCREEN
            System.Console.WriteLine("\t1.User Registration\n\t2.User Login\n\t3.Exit");
            System.Console.WriteLine("Enter Your Choice : ");
            int choice=int.Parse(Console.ReadLine());
            //SWITCH STATEMENT IS USED TO PICK A CHOICE SHOWN IN MAINMENU
            switch(choice)
            {
                case 1:
                {
                    //Registration method is called whwn user enter choice 1
                    Registration();
                    break;
                }
                case 2:
                {
                    //Login method is called when user enter choice 2
                    Login();
                    break;
                }
                case 3:
                {
                    //When user enter choice 3 user is exited
                    //here breaker is used to break the loop and exit from the application
                    statement="no";
                    break;
                }
            }
            
          }while(statement=="yes");
           

        }
        /// <summary>
        /// registration method is used to Register to the new User
        /// </summary>
        public static void Registration()
        {
            System.Console.WriteLine("***REGISTRATION***");
            System.Console.WriteLine("-------------------");
            //when user enters into the Registration method user starts enrolling he/her details
            System.Console.WriteLine("Enter Your Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter Your FatherName: ");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter Your MobileNumber: ");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your MailID: ");
            string mailID=Console.ReadLine();
            System.Console.WriteLine("Enter your Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine());
            System.Console.WriteLine("Enter Your Workstation Be like(WS101) :");
            string workStatioNumber=Console.ReadLine();
            System.Console.WriteLine("Enter your Initial Balance: ");
            double balance=double.Parse(Console.ReadLine());

            UserDetails newUser=new UserDetails(name,fatherName,gender,mobileNumber,mailID,workStatioNumber,balance);
            usersList.Add(newUser);

            System.Console.WriteLine("Your Registration is SuccessFull");
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("Your RegistrationID is: "+newUser.UserID);
        }
        /// <summary>
        /// Login method is used login Excited user
        /// </summary>
        public static void Login()
        {
            //Login Method is Called
            System.Console.WriteLine("***LOGIN***");
            System.Console.WriteLine("------------");
            //When user Enter into the Login Page Ask user to Enter Registered ID
            System.Console.WriteLine("Enter Your UserID: ");
            string userID=Console.ReadLine().ToUpper();
            //here flag is used as Temporary variable
            int flag=0;
            //Traverse the UserDetails list to find the userID is Already Excisted
            foreach(UserDetails tempUser in usersList)
            {
                if(userID==tempUser.UserID)
                {
                    //show UserID is Found
                    System.Console.WriteLine("UserID Is Found");
                    System.Console.WriteLine("---------------");
                    //When the userID is Found Collect the Overall Details Of User and store it to the UserDetails Object
                    loggedUser=tempUser;
                    flag=1;
                    //When user Enter validID show SubMenu to the user
                    SubMenu();
                }
                
            }
            //when the Condition Returns 0 it show Invalid ID to the user
            if(flag==0)
            {
                System.Console.WriteLine("UserID is Invalid\n Pleasse Enter Invalid Input");
            }
        }
        /// <summary>
        /// Submenu method is used to show the  page to the user
        /// </summary>
        public static void SubMenu()
        {
            
            //ITS CONTINUES SHOW MAINMENU WHEN CONDITION IN YES
            string statement="yes";
            // DO WHILE LOOP IS USED TO SHOW REPEATLY MAINMENU METHOD WHEN USER WANTS TO REGISTER OR LOGIN OR EXIT
            do
            {
            System.Console.WriteLine("***SUBMENU***");
            System.Console.WriteLine("\t1.Show My Profile\n\t2.FoodOrder\n\t3.CancelOrder\n\t4.Order History\n\t5.WalletRecharge\n\t6.Exit");
            System.Console.WriteLine("Enter Your Choice: ");
            int choice=int.Parse(Console.ReadLine());
            //SWITCH STATEMENT IS USED TO PICK A CHOICE SHOWN IN SUBMENU
                switch(choice) 
                {
                    case 1:
                    {
                        //Show my Profile Method is Called
                        ShowMyProfile();
                        break;
                    }
                    case 2:
                    {
                        //users Enter choice 2 FoodOrder Method is Called
                        FoodOrder();
                        break;
                    }
                    case 3:
                    {
                        //users Enter choice 3 Cancelorder Method is Called
                        CancelOrder();
                        break;
                    }
                    case 4:
                    {
                        //users Enter choice 4 OrderHistory Method is Called
                        OrderHistory();
                        break;
                    }
                    case 5:
                    {
                        //users Enter choice 5 WalletRecharge Method is Called
                       WalletRecharge();
                       break;
                    }
                    case 6:
                    {
                        //When user enter choice 3 user is exited
                    //here breaker is used to break the loop and exit from the SubMenu
                        statement="no";
                        break;
                    }
                }
            }while(statement=="yes");
        }
        /// <summary>
        /// Showmyprofile method is used to show the User Profile details to the User
        /// </summary>
        public static void ShowMyProfile()
        {
            System.Console.WriteLine("|USERID|\t|USERNAME|\t|FATHERNAME|\t|MOBILENUMBER|\t\t|MAILID|\t|GENDER|\t|WORKSTATTIONNUMBER|\t|BALANCE|");
            //Traverse the userDetails to find the loggedUserID and show the Profile to the User
            foreach(UserDetails tempUser in usersList)
            {
                //It check the condition when it find the userID it shows only the Logedin user Profile
                if(loggedUser.UserID==tempUser.UserID)
                {
                System.Console.WriteLine($"{tempUser.UserID}\t\t{tempUser.Name}\t\t{tempUser.FatherName}\t{tempUser.MobileNumber}\t{tempUser.MailID}\t{tempUser.Gender}\t{tempUser.WorkStationNumber}\t{tempUser.WalletBalance}");
                }
            }
        }
        /// <summary>
        /// WalletRecharge method is used to AddAmount to the user Wallet
        /// </summary>
        public static void WalletRecharge()
        {
            //WalletRecharge Method is Called
            string statement="yes";
            string choice=null;
            //Do While loop is used to Ask the User to Add Amount Repeatly
            do
            {
                System.Console.WriteLine("***WalletRecharge***");
                System.Console.WriteLine("--------------------");
                System.Console.WriteLine("Do you Want to Recharge Your Wallet: ");
                choice=Console.ReadLine().ToLower();
                //When the User Enter a Statement it check the Condition whether he/she want to RechargeWallet
                if(choice=="yes")
                {
                    System.Console.WriteLine("Enter a Amount to Add in Your Wallet: ");
                    double addAmount=double.Parse(Console.ReadLine());
                    //walletRecharge it calls the Method and it take Process and Add Amount in the Current LoggedUser
                    loggedUser.WalletRecharge(addAmount);
                    System.Console.WriteLine("***Amount Added SuccessFully***");
                    System.Console.WriteLine("Your WalletBalance is :"+loggedUser.WalletBalance);
                }
                //Here breaker is used to break the loop and exit from it exit from the WalletBalance
                System.Console.WriteLine("Do You want to Exit From WalletBalance: ");
                statement=Console.ReadLine().ToLower();
            }while(statement=="no");
        }
        /// <summary>
        /// OrderHistory method is usedto show the current Login user History
        /// </summary>
        public static void OrderHistory()
        {
            //ORDERHISTORY METHOD IS CALLED
            System.Console.WriteLine("***ORDERHISTORY***");
            //Show the Current Customer OrderDetails using foreach to traverse the orderDetails in ordersList
            System.Console.WriteLine("|ORDERID|\t|USERID|\t|ORDERDATE|\t|TOTALPRICE|\t|ORDERSTATUS|");
            foreach(OrderDetails tempOrder in ordersList)
            {
                //It check the Condition if the LoggedUserID and OrderList userId is Same it prints Whole OrderDetails of the CurrentLoggedIn Customer
                if(loggedUser.UserID==tempOrder.UserID)
                {
                    System.Console.WriteLine($"{tempOrder.OrderID}\t\t{tempOrder.UserID}\t\t{tempOrder.OrderDate.ToString("dd/MM/yyyy")}\t\t{tempOrder.TotalPrice}\t\t{tempOrder.Status}");
                }
            }

        }
        /// <summary>
        /// CancelOrder is used to Cancel the Order whetheruser wants to cancel the purchased item
        /// </summary>
        public static void CancelOrder()
        {
            System.Console.WriteLine("***CANCELORDER***");
            //using Foreach to traverse the OrderId to find whether he/She is Booked Order
             System.Console.WriteLine("|ORDERID|\t|USERID|\t|ORDERDATE|\t|TOTALPRICE|\t|ORDERSTATUS|");
            foreach(OrderDetails tempOrder in ordersList)
            {
                //it check the OrderUserId and Checking whether Customer is Ordered Product
                if(tempOrder.UserID==loggedUser.UserID && tempOrder.Status==OrderStatus.Ordered)
                {
                    System.Console.WriteLine($"{tempOrder.OrderID}\t\t{tempOrder.UserID}\t\t{tempOrder.OrderDate.ToString("dd/MM/yyyy")}\t\t{tempOrder.TotalPrice}\t\t{tempOrder.Status}");
                }
            }
            System.Console.WriteLine("Enter a OrderID to CancelOrder: ");
            string userOrderID=Console.ReadLine().ToUpper();
            int temp=0;
            double addAmount=0;
            //using Foreach to traverse Orderslist to check the user Enters OrderID is same it takes Process to CancelOrder
            foreach(OrderDetails tempOrder in ordersList)
            {
                if(tempOrder.OrderID==userOrderID)
                {
                    System.Console.WriteLine("OrderID is Found");
                    System.Console.WriteLine("----------------");
                    temp=1;
                    addAmount+=tempOrder.TotalPrice;
                    tempOrder.Status=OrderStatus.Cancelled;
                    //money will be Refunded user cancel the Order
                    loggedUser.WalletRecharge(addAmount);
                    //using foreach to traverse the CartItem to add Order Quantity in the item
                    foreach(CartItem tempCart in itemsList)
                    {
                        foreach(FoodDetails tempfoods in foodsList)
                        {
                            if(tempCart.FoodID==tempfoods.FoodID && tempCart.OrderID==tempOrder.OrderID)
                            {
                                tempfoods.AvailableQuantity+=tempCart.OrderQuantity;
                                System.Console.WriteLine("Order is Cancelled SUccessFully");
                            }
                        }
                    }
                    System.Console.WriteLine("Order is Cancelled SuccessFully");
                }
            }
            if(temp==0)
            {
                System.Console.WriteLine("Invalid Input");
            }
            
        }
        /// <summary>
        /// FoodOrder Method is used to Purchase the item to the current logged User
        /// </summary>
        public static void FoodOrder()
        {
            //FoodOrder Method is Called
            System.Console.WriteLine("***FOODORDER***");
            //using foreach to traverse the FoodDetails And show to the Customer
            System.Console.WriteLine("|FOODID|\t|FOODNAME|\t|FOODPRICE|\t|AVAILABLEQUANTITY|");
            foreach(FoodDetails tempFood in foodsList)
            {
                System.Console.WriteLine($"{tempFood.FoodID}\t\t{tempFood.FoodName}\t\t{tempFood.FoodPrice}\t\t{tempFood.AvailableQuantity}");
            }
            //Creting Object to CurrentLogged user to initiated
            OrderDetails newOrdered=new OrderDetails(loggedUser.UserID,DateTime.Now,0,OrderStatus.Initiated);
            //creating Temporary list to add the OrderedFood
            List<CartItem> tempCarts=new List<CartItem>();
            string statement=null,statement1=null,statement2=null;
            int temp=0,flag=0;
            double totalAmount=0,overallAmount=0;
            //DO while loop is used to ask the user repeatly to Addcart 
            do{
            //Ask the User to Pick the FoodID
            System.Console.WriteLine("Choose a FoodID: ");
            string givenFoodID=Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter a Amount of Quantity you Need: ");
            int givenQuantity=int.Parse(Console.ReadLine());
            //using foreach to traverse the Foodslist to book the Order
            foreach(FoodDetails tempFood in foodsList)
            {
                //check the condition whether given user foodId and GivenQauntity is true
                if(tempFood.FoodID==givenFoodID && tempFood.AvailableQuantity>=givenQuantity)
                {
                    temp=1;
                    tempFood.AvailableQuantity-=givenQuantity;
                    totalAmount=givenQuantity * tempFood.FoodPrice;
                    System.Console.WriteLine("TotalAmount of Food is: "+totalAmount);
                    CartItem newbooked=new CartItem(loggedUser.UserID,givenFoodID,totalAmount,givenQuantity);
                    tempCarts.Add(newbooked);
                }
            }
            //whether the user enters mistakenly input it shows the Customer Invalid Input
            if(temp==0)
            {
                System.Console.WriteLine("Invalid Input \n Please Enter Valid Input");
            }
            //Here is the Condition breaker to break tha Do while Loop
            System.Console.WriteLine("Do you want to AddCart: ");
            statement=Console.ReadLine().ToLower();

            }while(statement=="yes");
            //Ask the user whether he/she wants to Confirm the purchase Order which are added in CartsList
            do
            {
            System.Console.WriteLine("Do you Want to Confirm the Purchase: ");
            statement1=Console.ReadLine().ToLower();
            if(statement1=="yes")
            {
                foreach(CartItem tempCart in tempCarts)
                {
                    overallAmount=tempCart.OrderPrice * tempCart.OrderQuantity;
                }
                if(overallAmount>=loggedUser.WalletBalance)
                {
                    //if user has aSuffient Balance Amount will Be Dectuted from the User Wallet
                    loggedUser.Deduct(overallAmount);
                    //Append the Tempcart object to the CartItems list
                    foreach(CartItem tempcart in tempCarts)
                    {
                      itemsList.Add(tempcart);
                      System.Console.WriteLine("Ordered SuccessFully");  
                      System.Console.WriteLine("Your Ordered ID is:"+tempcart.OrderID);
                    }
                }
                else
                {
                    System.Console.WriteLine("Insuffient Balance");
                    System.Console.WriteLine("Do you want to Recharge Your Wallet: ");
                    statement2=Console.ReadLine().ToLower();
                    if(statement2=="yes")
                    {
                        WalletRecharge();
                    }
                }
            }
            else
            {
                System.Console.WriteLine("|ITEMID|\t|ORDERID|\t|FOODID|\t|ORDERPRICE|\t|ORDERQUANTITY|");
                //foreach is used to traverse tempCarts to show the addedCartlist
                foreach(CartItem tempCart in tempCarts)
                {
                System.Console.WriteLine($"{tempCart.ItemID}\t\t{tempCart.OrderID}\t\t{tempCart.FoodID}\t\t{tempCart.OrderPrice}\t\t{tempCart.OrderQuantity}");
                }
            }

            }while(flag==0);

        }

    }
    
}