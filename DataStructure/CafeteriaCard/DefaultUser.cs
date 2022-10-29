using System;
namespace CafeteriaCard
{
    public partial class  Operations
    {
        public static void DefaultUser()
        {
            UserDetails user1=new UserDetails("Ravichandran","Ettaparajan",Gender.Male,8857777757,"ravi@29gmail.com","WS101",400);
            usersList.Add(user1);
            UserDetails user2=new UserDetails("Baskaran","SethuRajan",Gender.Male,1234567890,"Basakaran56@gamil.com","WS101",500);
            usersList.Add(user2);

            FoodDetails food1=new FoodDetails("Coffee",20,100);
            foodsList.Add(food1);
            FoodDetails food2=new FoodDetails("Tea",15,100);
            foodsList.Add(food2);
            FoodDetails food3=new FoodDetails("Biscuit",10,100);
            foodsList.Add(food3);
            FoodDetails food4=new FoodDetails("Juice",50,100);
            foodsList.Add(food4);
            FoodDetails food5=new FoodDetails("Puff",40,100);
            foodsList.Add(food5);
            FoodDetails food6=new FoodDetails("Milk",10,100);
            foodsList.Add(food6);
            FoodDetails food7=new FoodDetails("PopCorn",20,10);
            foodsList.Add(food7);

            OrderDetails order1=new OrderDetails(user1.UserID,new DateTime(2022,06,15),70,OrderStatus.Ordered);
            ordersList.Add(order1);
            OrderDetails order2=new OrderDetails(user2.UserID,new DateTime(2022,06,15),100,OrderStatus.Ordered);
            ordersList.Add(order2);


            CartItem item1=new CartItem(order1.OrderID,food1.FoodID,20,1);
            itemsList.Add(item1);
            CartItem item2=new CartItem(order1.OrderID,food3.FoodID,10,1);
            itemsList.Add(item2);
            CartItem item3=new CartItem(order1.OrderID,food5.FoodID,40,1);
            itemsList.Add(item3);
            CartItem item4=new CartItem(order2.OrderID,food3.FoodID,10,1);
            itemsList.Add(item4);
            CartItem item5=new CartItem(order2.OrderID,food4.FoodID,50,1);
            itemsList.Add(item5);
            CartItem item6=new CartItem(order2.OrderID,food5.FoodID,40,1);
            itemsList.Add(item6);
        }
    }
}