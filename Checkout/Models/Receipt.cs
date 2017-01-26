using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Models
{
    public class Receipt
    {
        public static double FuelPerks { get; set; }
        public static double FuelPerksTowards { get; set; }
        public double SubTotal { get; set; }
        public double Discount { get; set; }
        public double Total { get { return Math.Round(SubTotal - Discount,2); } }

        public Receipt(double subTotal, double discount)
        {
            SubTotal = subTotal;
            Discount = discount;

            CalculateFuelPerks();
        }

        private void CalculateFuelPerks()
        {
            FuelPerksTowards += Total;

            double NewPerks = (int)Math.Floor(FuelPerksTowards / 50);

            FuelPerksTowards = FuelPerksTowards % 50;

            FuelPerks += NewPerks * .10;
        }
    }
}
