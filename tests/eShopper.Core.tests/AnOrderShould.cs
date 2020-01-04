using Xunit;

namespace eShopper.Core.tests
{
    public class AnOrderShould
    {
        [Fact]
        public void BeAbleToAddACart()
        {
            Cart c = new Cart();
            c.AddItem(new Item(){
                Name = "Microsot Mouse",
                Quantity = 1,
                Price = 10                
            });

            Order o = new Order();
            o.cart = c;

            Assert.Equal(o.cart,c);
        }

        [Fact]
        public void BeAbleToProvideAPayment()
        {
            Cart c = new Cart();
            c.AddItem(new Item(){
                Name = "Microsot Mouse",
                Quantity = 1,
                Price = 10                
            });

            Order o = new Order();
            o.cart = c;
            o.address = new Address()
            {
                HouseNum =  6969,
                Street = "IDK",
                Area = "IDK",
                State = "IDK",
                Country = "IDK"
            };
        }

    }
}