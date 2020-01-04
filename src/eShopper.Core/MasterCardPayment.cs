using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace eShopper.Core
{
    public class MasterCardPayment : IPayment
    {
        public string CardNumber { get; set ; }
        public string CVV { get ; set ; }
        public string PaymentServer { get { return "http://payment.mastercard.com/getpayment"; } }

        public bool GetPayment(double Amount)
        {
            //going to the MasterCard payment server and returing true or 
            Random rnd = new Random();
            int randValue = rnd.Next(0, 1);
            //simulate Payment is successful
            if (randValue == 0)
            {
                Thread.Sleep(2000);
                return true;
            }//simulate payment failed
            else
            {

                Thread.Sleep(2000);
                return false;
            }

        }
    }
}
