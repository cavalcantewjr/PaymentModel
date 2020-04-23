using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, 
            string boletoNumber, 
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            string payer,
            string document,
            decimal totalPaid,
            string address, string email) : base(
                paidDate,
                expireDate,
                total,
                payer,
                document,
                totalPaid,
                address,
                email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}
