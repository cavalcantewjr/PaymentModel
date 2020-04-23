using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        public Payment(DateTime paidDate, DateTime expireDate, decimal total, string payer, string document, decimal totalPaid, string address, string email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            Payer = payer;
            Document = document;
            TotalPaid = totalPaid;
            Address = address;
            Email = email;
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public Decimal Total { get; private set; }
        public string Payer { get; private set; }
        public string Document { get; private set; }
        public Decimal TotalPaid { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
    }
}
