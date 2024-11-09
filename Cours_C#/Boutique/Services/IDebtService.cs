using Boutique.Entities;
using System.Collections.Generic;

namespace Boutique.Services
{
    public interface IDebtService
    {
        void CreateDebt(Debt debt);
        object GetAllDebts();
        List<Debt> GetDebtsByClient(Client client);
        List<Debt> GetUnpaidDebts(Client client);
        void UpdateDebt(Debt debt);
    }
}
