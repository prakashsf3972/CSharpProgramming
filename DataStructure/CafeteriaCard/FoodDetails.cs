namespace CafeteriaCard
{
    public class FoodDetails
    {
        /// <summary>
        /// Field s_foodID with Auto Increment is used to provide unique foodID to every user
        /// </summary>
        private static int s_foodID=100;
        /// <summary>
        ///  Property FoodID with is used to provide unique foodID to every user
        /// </summary>
        /// <value></value>
        public string FoodID { get;}
        /// <summary>
        /// Property FoodName with is used to provide unique FoodName to every user
        /// </summary>
        /// <value></value>
        public string FoodName { get; set; }
        /// <summary>
        /// Property FoodPrice with is used to provide unique FoodPrice to every user
        /// </summary>
        /// <value></value>
        public double FoodPrice { get; set; }
        /// <summary>
        /// Property AvailableQuantity with is used to provide unique AvailableQuantity to every user
        /// </summary>
        /// <value></value>
        public double AvailableQuantity { get; set; }
        /// <summary>
        /// Default User
        /// </summary>
        public FoodDetails()
        {

        }
        /// <summary>
        /// Constructor FoodDetails is used to collect the details of FoodDetails
        /// </summary>
        /// <param name="foodName"></param>
        /// <param name="foodPrice"></param>
        /// <param name="availableQuantity"></param>
        public FoodDetails(string foodName,double foodPrice,double availableQuantity)
        {
            s_foodID++;
            FoodID="FID"+s_foodID;
            FoodName=foodName;
            FoodPrice=foodPrice;
            AvailableQuantity=availableQuantity;
        }
        /// <summary>
        /// Constructor FoodDetails is used to collect the details of FoodDetails
        /// </summary>
        /// <param name="data"></param>
        public FoodDetails(string data)
        {
            string[] values=data.Split(',');
            s_foodID=int.Parse(values[0].Remove(0,3));
            FoodID=values[0];
            FoodName=values[1];
            FoodPrice=double.Parse(values[2]);
            AvailableQuantity=double.Parse(values[3]);
        }
    }
}