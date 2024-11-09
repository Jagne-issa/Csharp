using Boutique.Entities;
using Boutique.Services;
using System;
using System.Linq;

namespace Boutique.Views
{
    public class PaymentView
    {
        private readonly IPaymentService _paymentService;
        private readonly IDebtService _debtService;
        private object debtId;

        public PaymentView(IPaymentService paymentService, IDebtService debtService)
        {
            _paymentService = paymentService;
            _debtService = debtService;
        }

        public void RecordPayment()
        {
            Console.Write("Enter debt ID: ");
            // int debtId = int.Parse(Console.ReadLine());
            // Debt debt = _debtService.GetAllDebts().FirstOfDefault(d => d.Id == debtId);

            // if (debt == null)
            // {
            //     Console.WriteLine("Debt not found.");
            //     return;
            // }

            List<Debt> debts = _debtService.GetAllDebts() as List<Debt>;
            if (debts == null)
            {
                Console.WriteLine("Error retrieving debts.");
                return;
            }

            Debt debt = debts.FirstOrDefault(d => d.Id == debtId);



            Console.Write("Enter payment date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Payment payment = new Payment
            {
                Debt = debt,
                Date = date,
                Amount = (double)amount
            };
            _paymentService.RecordPayment(payment);
            debt.AmountPaid += (double)amount;
            debt.RemainingAmount -= (double)amount;
            _debtService.UpdateDebt(debt);

            Console.WriteLine("Payment recorded successfully!");
        }
    }
}
