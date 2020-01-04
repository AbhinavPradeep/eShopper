using System.Collections.Generic;

namespace eShopper.Core
{
    public class Cart
    {
        private List<Item> Items = new List<Item>();
        public bool AddItem(Item item)
        {
            Items.Add(item);
            return true;
        }
        public bool RemoveItem(Item item)
        {
            Items.Remove(item);
            return true;
        }
        public List<Item> ListItems()
        {
           return Items;
        }
        public bool UpdateItem(Item OldItem,Item NewItem)
        {
           Items.Remove(OldItem);
           Items.Add(NewItem);
           return true;
        }

        public double  CartTotalPrice
        {
            get
            {
                double TotalPrice = 0.0;
                foreach (var item in Items)
                {
                    TotalPrice = TotalPrice + item.Price;
                }

                return TotalPrice;
            }
        }
    }
}
