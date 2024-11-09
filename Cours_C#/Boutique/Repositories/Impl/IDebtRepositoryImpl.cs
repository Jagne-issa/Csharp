using Boutique.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Boutique.Repositories
{
    public class DebtRepositoryImpl : IDebtRepository
    {
        private List<Debt> debts = new List<Debt>();

        public void Add(Debt debt) => debts.Add(debt);
        public void Update(Debt debt)
        {
            var existingDebt = debts.FirstOrDefault(d => d.Date == debt.Date && d.Amount == debt.Amount);
            if (existingDebt != null)
            {
                existingDebt.AmountPaid = debt.AmountPaid;
                existingDebt.RemainingAmount = debt.RemainingAmount;
                existingDebt.Articles = debt.Articles;
                existingDebt.Payments = debt.Payments;
            }
        }
        public void Delete(Debt debt) => debts.Remove(debt);
        public Debt GetById(int id) => id >= 0 && id < debts.Count ? debts[id] : null;
        public List<Debt> GetAll() => debts;

        public List<Debt> GetUnpaidDebts(Client client) => debts.Where(d => d.RemainingAmount > 0).ToList();
    }
}
