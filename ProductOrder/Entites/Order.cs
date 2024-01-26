using ProductOrder.Entites.Enum;
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
        public Client client { get; set; }

        public Order(DateTime moment, OrderStatus status, OrderItem item, Client client)
        {
            this.moment = moment;
            this.status = status;
            this.item = item;
            this.client = client;
        }

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
        public override string ToString()
        {
            return "ORDER SUMMARY:" +
                "\nOrder moment: " + moment +
                "\nOrder Status: " + status +
                "\n" + client.ToString() +
                "\n" + items.ToString() +
                "\nTotal price: $" + total();

        }
    }
}
