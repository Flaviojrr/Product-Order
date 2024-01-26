using ProductOrder.Entites;
using ProductOrder.Entites.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool op;
            OrderStatus status;
            Console.Write("Enter cliente data: \nName: ");
            string newName = Console.ReadLine();
            Console.Write("Email: ");
            string newEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime newBirthDate = DateTime.Parse(Console.ReadLine());
            Client newClient = new Client(newName, newEmail,newBirthDate);
            
            do
            {
                Console.Write("Enter order data: \nStatus: ");
                string newStatus = Console.ReadLine();
                if (!Enum.TryParse<OrderStatus>(newStatus, out status))
                {
                    Console.WriteLine("Status do pedido invalido.");
                    op = false;
                }
                else
                {
                    op=true;
                }
            } while (op != true);
            
            Console.Write("How many items to this order? ");
            int itemsQuantities = int.Parse(Console.ReadLine());
            for(int i=0;i<itemsQuantities;i++) 
            {
                Console.Write($"Enter #{i} item data \nProduct name: ");
                string newProductName = Console.ReadLine();
                Console.Write("Product price: ");
                double newProductPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());
                Product newItem = new Product(newProductName, newProductPrice);
                OrderItem newOrderItem = new OrderItem(productQuantity, productQuantity);
                Order newOrder = new Order();
            }

        }
    }
}
