using Boutique.Entities;
using System.Collections.Generic;

namespace Boutique.Repositories
{
    public class PaymentRepositoryImpl : IPaymentRepository
    {
        private List<Payment> payments = new List<Payment>();

        public void Add(Payment payment) => payments.Add(payment);
        public void Update(Payment payment)
        {
            var existingPayment = payments.FirstOrDefault(p => p.Date == payment.Date && p.Amount == payment.Amount);
            if (existingPayment != null)
            {
                existingPayment.Amount = payment.Amount;
            }
        }
        public void Delete(Payment payment) => payments.Remove(payment);
        public Payment GetById(int id) => id >= 0 && id < payments.Count ? payments[id] : null;
        public List<Payment> GetAll() => payments;
    }
}
