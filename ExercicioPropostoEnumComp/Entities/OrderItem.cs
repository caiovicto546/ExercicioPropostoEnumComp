using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoEnumComp.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get;set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity)
        {
            this.Quantity = quantity;
            this.Price = Product.Price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
    }
}
