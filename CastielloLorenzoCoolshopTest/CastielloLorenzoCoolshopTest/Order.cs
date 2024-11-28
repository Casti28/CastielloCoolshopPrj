using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastielloLorenzoCoolshopTest
{
    internal class Order
    {
        public int Id { get; set; }
        public string? ArticleName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double PercentageDiscount { get; set; }
        public string? Buyer { get; set; }

        public override string ToString()
        {
            return $"Id={Id.ToString()}" +
                $", Article Name={ArticleName}" +
                $", Quantity={Quantity.ToString()}" +
                $", Unit Price={UnitPrice.ToString()}" +
                $", Percentage Discount={PercentageDiscount.ToString()}" +
                $", Buyer={Buyer}";
        }
    }
}
