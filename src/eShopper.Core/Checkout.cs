using System.Collections.Generic;

namespace eShopper.Core
{
    public class Checkout
    {
        public Order order{get;set;}
        public VisaPayment payment {get;set;}

    }
}