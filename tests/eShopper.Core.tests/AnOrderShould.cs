using Xunit;

namespace eShopper.Core.tests
{
    public class AnOrderShould
    {
        [Fact]
        public void BeAbleToAddACart()
        {
            Cart c = new Cart();
            c.AddItem(new Item()
            {
                Name = "Microsot Mouse",
                Quantity = 1,
                Price = 10
            });

            Order o = new Order();
            o.cart = c;

            Assert.Equal(o.cart, c);
        }

        [Fact]
        public void BeAbleToProvideAPayment()
        {
            Cart c = new Cart();
            c.AddItem(new Item()
            {
                Name = "Microsot Mouse",
                Quantity = 1,
                Price = 10
            });

            Order o = new Order();
            o.cart = c;
            o.address = new Address()
            {
                HouseNum = 6969,
                Street = "IDK",
                Area = "IDK",
                State = "IDK",
                Country = "IDK"
            };
        }

        [Fact]
        public void AllowCartToBeCheckedout()
        {
            //Given

            Cart c = new Cart();
            c.AddItem(new Item()
            {
                Name = "Microsot Mouse",
                Quantity = 1,
                Price = 10
            });

           
            //When
            Order o = new Order();
           
            Address address = new Address()
            {
                HouseNum = 6969,
                Street = "IDK",
                Area = "IDK",
                State = "IDK",
                Country = "IDK"
            };

            IPayment payment = new VisaPayment();
            IPayment MastercardPayment = new MasterCardPayment();

            payment.CardNumber = "343434343435645656";
            payment.CVV = "123";

            //Then
            o.Checkout(c, address,payment);
            Assert.Equal(o.OrderStatus, OrderStatus.Confirmed);
        }

    }
}