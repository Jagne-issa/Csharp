using Boutique.Entities;
using Boutique.Services;
using System;
using System.Collections.Generic;

namespace Boutique.Views
{
    public class DebtView
    {
        private readonly IDebtService _debtService;
        private readonly IClientService _clientService;

        public DebtView(IDebtService debtService, IClientService clientService)
        {
            _debtService = debtService;
            _clientService = clientService;
        }

        public void CreateDebt()
        {
            Console.Write("Enter client phone: ");
            string phone = Console.ReadLine();
            Client client = _clientService.GetClientByPhone(phone);

            if (client == null)
            {
                Console.WriteLine("Client not found.");
                return;
            }

            Console.Write("Enter debt date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter total amount: ");
            decimal totalAmount = decimal.Parse(Console.ReadLine());

            Debt debt = new Debt
            {
                Client = client,
                Date = date,
                TotalAmount = totalAmount,
                AmountPaid = 0,
                RemainingAmount = (double)totalAmount
            };
            _debtService.CreateDebt(debt);
            Console.WriteLine("Debt created successfully!");
        }

        public void ListUnpaidDebts()
        {
            Console.Write("Enter client phone: ");
            string phone = Console.ReadLine();
            Client client = _clientService.GetClientByPhone(phone);

            if (client == null)
            {
                Console.WriteLine("Client not found.");
                return;
            }

            List<Debt> debts = _debtService.GetUnpaidDebts(client);
            Console.WriteLine("Unpaid Debts:");
            foreach (var debt in debts)
            {
                Console.WriteLine($"ID: {debt.Id}, Date: {debt.Date}, Total Amount: {debt.TotalAmount}, Remaining Amount: {debt.RemainingAmount}");
            }
        }

        internal void ListDebtRequests()
        {
            throw new NotImplementedException();
        }

        internal void ListUnsettledDebts()
        {
            throw new NotImplementedException();
        }

        internal void MakeDebtRequest()
        {
            throw new NotImplementedException();
        }

        internal void SendReminderForCancelledRequest()
        {
            throw new NotImplementedException();
        }
    }
}
