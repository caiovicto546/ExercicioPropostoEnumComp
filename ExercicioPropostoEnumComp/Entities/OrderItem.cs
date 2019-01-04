﻿using System;
using System.Collections.Generic;
using System.Globalization;
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

        public OrderItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Product.Price.ToString("F2",CultureInfo.InvariantCulture) + ", Quantity: " + Quantity + ", Subtotal: $" + SubTotal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
