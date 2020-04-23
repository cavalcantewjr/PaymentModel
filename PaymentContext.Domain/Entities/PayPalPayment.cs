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
            string document, 
            decimal totalPaid, 
            string address, string email): base(
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
