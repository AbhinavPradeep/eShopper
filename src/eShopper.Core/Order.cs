using System;
using System.Threading;
using System.Collections.Generic;

namespace eShopper.Core
{
    public class Order
    {
        public Cart cart{get;set;}
        public Address address{get;set;}
        public OrderStatus OrderStatus;

        public double OrderPrice
        {
            get
            {
                return cart.CartTotalPrice + 30/100 *cart.CartTotalPrice;
            }
        } 

        public OrderStatus Checkout(Cart cart, Address address, IPayment cardPayment)
        {
            bool PaymentStatus = false;
            this.cart = cart;
            PaymentStatus = cardPayment.GetPayment(this.OrderPrice);

            if(PaymentStatus == true)
                 OrderStatus = OrderStatus.Confirmed;
            else
                 OrderStatus = OrderStatus.Cancelled;

            return OrderStatus;
        }

    }
}