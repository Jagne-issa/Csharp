using Boutique.Entities;
using System.Collections.Generic;

namespace Boutique.Repositories
{
    public interface IDebtRepository : IRepository<Debt>
    {
        List<Debt> GetUnpaidDebts(Client client);
    }
}
