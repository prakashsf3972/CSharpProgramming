namespace CafeteriaCard
{
    public interface IBalance
    {
        /// <summary>
        /// Property WalletBalance is used store the User Balance in wallet
        /// </summary>
        /// <value></value>
         public double WalletBalance { get; }
            /// <summary>
            /// Method WalletRecharge is Used to Recharge Amount in the Wallet 
            /// </summary>
            /// <param name="amount"></param>
         public void WalletRecharge(double amount);
    }
}