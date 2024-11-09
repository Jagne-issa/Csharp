using Boutique.Entities;
using System.Collections.Generic;

namespace Boutique.Services
{
    public interface IPaymentService
    {
        void RecordPayment(Payment payment);
        List<Payment> GetAllPayments();
    }
}
