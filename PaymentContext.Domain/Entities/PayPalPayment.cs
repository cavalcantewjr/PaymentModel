using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(
            string transactionCode, 
            DateTime paidDate, 
            DateTime expireDate, 
            decimal total, 
            string payer,
            Document document, 
            decimal totalPaid, 
            Address address, Email email): base(
                paidDate,  
                expireDate,  
                total,  
                payer,  
                document,  
                totalPaid,  
                address,  
                email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; set; }
    }
}
