using System;
using System.Collections.Generic;

namespace Boutique.Entities
{
    public class Debt
    {
        internal Client Client;
        internal object Id;
        internal decimal TotalAmount;

        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public double AmountPaid { get; set; }
        public double RemainingAmount { get; set; }
        public List<Article> Articles { get; set; }
        public List<Payment> Payments { get; set; }

        public Debt(DateTime date, double amount, double amountPaid, double remainingAmount, List<Article> articles)
        {
            Date = date;
            Amount = amount;
            AmountPaid = amountPaid;
            RemainingAmount = remainingAmount;
            Articles = articles;
            Payments = new List<Payment>();
        }

        public Debt() { }
    }
}
