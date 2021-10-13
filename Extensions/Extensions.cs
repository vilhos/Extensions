using System;


namespace ShoppingApp
{
    public static class Extensions
    {
        public static bool IsAdult(this ShoppingBag source)
        {
            string answer = "";

            foreach (var item in source.products)
            {
                if (item.Name == "vodka")
                {
                    Console.WriteLine("are you 18, yes or no?");
                    answer = Console.ReadLine();
                }
            }
            return answer == "yes";
        }

        public static float TotalSum(this ShoppingBag source)
        {
            float total = 0;

            foreach (var item in source.products)
            {
                total += item.Price;
            }
            return total;
        }

        public static bool IsDiscount(this ShoppingBag source, out float sum)
        {
            float total = 0;
            int discount = 5;
            bool isdiscount = false;

            foreach (var item in source.products)
            {
                total += item.Price;
            }

            if (total >= 100)
            {
                sum = total - (total / 100 * discount);
                isdiscount = true;
            }

            else
                sum = total;

            return isdiscount;
        }

        public static float ChangedCash(this ShoppingBag source, float sum, int cash)
        {
            float changedCash = cash;

            foreach (var item in source.products)
            {
                changedCash -= item.Price;
            }
            return changedCash;
        }

        public static float TransferToBonusCard(this ShoppingBag source, float sum, ref int cash)
        {
            int changed = (int)source.ChangedCash(sum, cash);
            float temp = source.ChangedCash(sum, cash) - changed;
            cash = changed;
            source.bonusCard = temp;

            return source.bonusCard;
        }
    }
}
