using Boutique.Entities;
using Boutique.Repositories;
using System.Collections.Generic;

namespace Boutique.Services
{
    public class PaymentServiceImpl : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentServiceImpl(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public void RecordPayment(Payment payment) => _paymentRepository.Add(payment);

        public List<Payment> GetAllPayments() => _paymentRepository.GetAll();
    }
}
