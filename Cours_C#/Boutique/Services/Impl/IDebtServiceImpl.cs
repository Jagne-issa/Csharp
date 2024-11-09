using Boutique.Entities;
using Boutique.Repositories;
using System.Collections.Generic;

namespace Boutique.Services
{
    public class IDebtServiceImpl : IDebtService
    {
        private readonly IDebtRepository _debtRepository;

        public IDebtServiceImpl()
        {
        }

        public IDebtServiceImpl(IDebtRepository debtRepository)
        {
            _debtRepository = debtRepository;
        }

        public void CreateDebt(Debt debt) => _debtRepository.Add(debt);

        // public void CreateDebt(Debt debt)
        // {
        //     throw new NotImplementedException();
        // }

        public List<Debt> GetAllDebts()
        {
            throw new NotImplementedException();
        }

        // private List<Debt> _debts = new List<Debt>();

        // public IEnumerable<Debt> GetAllDebts()
        // {
        //     return _debts;
        // }

        public List<Debt> GetDebtsByClient(Client client) =>
            _debtRepository.GetAll().FindAll(d => d.Client == client);

        // public List<Debt> GetDebtsByClient(Client client)
        // {
        //     throw new NotImplementedException();
        // }

        public List<Debt> GetUnpaidDebts(Client client) => _debtRepository.GetUnpaidDebts(client);

        // public List<Debt> GetUnpaidDebts(Client client)
        // {
        //     throw new NotImplementedException();
        // }

        public void UpdateDebt(Debt debt) => _debtRepository.Update(debt);

        // public void UpdateDebt(Debt debt)
        // {
        //     throw new NotImplementedException();
        // }

        object IDebtService.GetAllDebts()
        {
            throw new NotImplementedException();
        }
    }
}
