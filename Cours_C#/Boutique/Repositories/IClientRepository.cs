using Boutique.Entities;

namespace Boutique.Repositories
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetByPhone(string phone);
    }
}
