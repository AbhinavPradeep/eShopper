using System;

namespace eShopper.Core
{
    public interface IPayment
    {
        string CardNumber { get; set; }
        string CVV { get; set; }
        bool GetPayment(double Amount);
        string PaymentServer { get; }
    }
    
}