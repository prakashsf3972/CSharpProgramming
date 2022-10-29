namespace CafeteriaCard
{
    public class CartItem
    {
        /// <summary>
        /// Field s_itemID with Auto Increment is used to provide unique itemID to every user
        /// </summary>
        private static int s_itemID=100;
        /// <summary>
        /// property ItemID is used to provide the unique userID to the user in the instance of the class <see cref =CartItem>
        /// </summary>
        /// <value></value>
        public string ItemID { get; }
        /// <summary>
        /// property OrderID is used to provide the unique OrderID to the user in the instance of the class <see cref =CartItem> 
        /// </summary>
        /// <value></value>
        public string OrderID { get; set; }
        /// <summary>
        /// property FoodID is used to provide the unique FoodID to the user in the instance of the class <see cref =CartItem> 
        /// </summary>
        /// <value></value>
        public string FoodID { get; set; }
        /// <summary>
        /// property OrderPrice is to provide the OrderPrice of the Item in the instance of the class <see cref =CartItem> 
        /// </summary>
        /// <value></value>
        public double OrderPrice { get; set; }
        /// <summary>
        /// property OrderQuantity is to provide the OrderQuantity of the Item in the instance of the class <see cref =CartItem> 
        /// </summary>
        /// <value></value>
        public int OrderQuantity { get; set; }
        /// <summary>
        /// Default User
        /// </summary>
        public CartItem()
        {
            
        }
        /// <summary>
        /// Constructor CartItems is used to collect the details of cartItems
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="foodID"></param>
        /// <param name="orderPrice"></param>
        /// <param name="orderQuantity"></param>
        public CartItem(string orderID,string foodID,double orderPrice,int orderQuantity)
        {
            s_itemID++;
            ItemID="ITID"+s_itemID;
            OrderID=orderID;
            FoodID=foodID;
            OrderPrice=orderPrice;
            OrderQuantity=orderQuantity;
        }
        /// <summary>
        /// Constructor CartItems is used to collect the details of cartItems
        /// </summary>
        /// <param name="data"></param>
        public CartItem(string data)
        {
            string[] values=data.Split(',');
            s_itemID=int.Parse(values[0].Remove(0,3));
            ItemID=values[0];
            OrderID=values[1];
            FoodID=values[2];
            OrderPrice=double.Parse(values[3]);
            OrderQuantity=int.Parse(values[4]);
        }
    }
}