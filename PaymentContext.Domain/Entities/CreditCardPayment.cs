using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{

    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(int cardHolderName, 
            string cardNumber, 
            string lastTransactionNumber, 
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            string payer,
            Document document,
            decimal totalPaid,
            Address address, Email email) : base(
                paidDate,
                expireDate,
                total,
                payer,
                document,
                totalPaid,
                address,
                email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public int CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }

}
