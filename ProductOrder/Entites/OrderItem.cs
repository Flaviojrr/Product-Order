﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrder.Entites
{
    internal class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }
        public Product product { get; set; }
        public OrderItem(int quantity, double price, Product product)
        {
            this.quantity = quantity;
            this.price = price;
            this.product = product;
        }

        public double subTotal()
        {
            return quantity * price;
        }
        public override string ToString()
        {
            return product.ToString() + ", Quantity: " + quantity + ", Subtotal: $" + subTotal();
        }
    }
}
