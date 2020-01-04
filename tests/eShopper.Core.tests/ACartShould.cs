using Xunit;
using System.Collections.Generic;

namespace eShopper.Core.tests
{
    public class ACartShould
    {
        [Fact]
        public void AllowAnItemToBeAddded()
        {
            Cart cart = new Cart();

            Item item1 = new Item();
            item1.Name = "Dell Alienware";
            item1.Quantity = 1;

            cart.AddItem(item1);
            
            List<Item> items = new List<Item>();
            items = cart.ListItems();
            Assert.Contains(item1, items);
        }

        [Fact]
        public void AllowItemsToBeRemoved()
        {
            Cart cart = new Cart();

            Item item1 = new Item();
            item1.Name = "Dell Alienware";
            item1.Quantity = 1;

            Item item2 = new Item();
            item2.Name = "Dell XPS";
            item2.Quantity = 1;

            cart.AddItem(item1);
            cart.AddItem(item2);

            cart.RemoveItem(item2);

            List<Item> items = new List<Item>();
            items = cart.ListItems();
            
            Assert.DoesNotContain(item2,items);
        }

        [Fact]
        public void AllowItemsToBeListed()
        { 
            Cart cart = new Cart();

            Item item1 = new Item();
            item1.Name = "Dell Alienware";
            item1.Quantity = 1;

            Item item2 = new Item();
            item2.Name = "Dell XPS";
            item2.Quantity = 1;

            cart.AddItem(item1);
            cart.AddItem(item2);

            cart.RemoveItem(item2);

            List<Item> ListedItems = new List<Item>();
            List<Item> items = new List<Item>();
            items = cart.ListItems();
            ListedItems =cart.ListItems();

            Assert.Equal(items,ListedItems);
 
        }
    }
}
