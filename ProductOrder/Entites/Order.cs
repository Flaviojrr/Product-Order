using ProductOrder.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrder.Entites
{
    internal class Order
    {
        double sum;
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
        public OrderItem item { get; set; }
        List<OrderItem> items = new List<OrderItem>();
        public void addItem(OrderItem item)
        {
            items.Add(item);
        }
        public void removeItem(OrderItem item) 
        {
            items.Remove(item);
        }
        public double total()
        {
            foreach (OrderItem item in items) 
            {
                sum += item.subTotal();
            }
            return sum; 
        }
    }
}
