using System;


namespace ShoppingApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShoppingBag MyBag = new ShoppingBag();
            MyBag.products.Add(new Product(5.4f, "chees"));
            MyBag.products.Add(new Product(10f, "vodka"));
            MyBag.products.Add(new Product(7.2f, "meat"));
            MyBag.bonusCard = 0;
            int cash = 100;
            float sum;

            Console.WriteLine($" Are you an adult: {MyBag.IsAdult()}");
            Console.WriteLine($" Amount to pay: {MyBag.TotalSum()}");
            Console.WriteLine($" Amount to pay after discount: {MyBag.IsDiscount(out sum)}");
            Console.WriteLine($" Your balance is: {MyBag.ChangedCash(sum, cash)}");
            Console.WriteLine($" Your balance in bonuscard is: {MyBag.TransferToBonusCard(sum, ref cash)}");
            Console.WriteLine($" Your balance after transfer in bonuscard: {cash}");

            Console.Read(); 
        }
    }
}
