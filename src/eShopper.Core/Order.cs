using System;
using System.Collections.Generic;

namespace eShopper.Core
{
    public class Order
    {
        public Cart cart{get;set;}
        public Address address{get;set;}

        public double OrderPrice
        {
            get
            {
                return cart.CartTotalPrice + 30/100 *cart.CartTotalPrice;
            }
        } 

    }
}