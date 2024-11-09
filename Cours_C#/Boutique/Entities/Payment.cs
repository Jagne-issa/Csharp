using System;

namespace Boutique.Entities
{
    public class Payment
    {
        internal Debt Debt;

        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public Payment(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }

        public Payment() { }
    }
}
