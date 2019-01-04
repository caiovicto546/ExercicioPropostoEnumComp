using System;
using ExercicioPropostoEnumComp.Entities;
using ExercicioPropostoEnumComp.Entities.Enums;

namespace ExercicioPropostoEnumComp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string email;
            DateTime date;
            int qtdOrder;
            Client client;
            Order order;
            OrderStatus status;


            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            client = new Client(name, email, date);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());

            order = new Order(client, status, DateTime.Now);

            Console.Write("How many items to this order? ");
            qtdOrder = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i<qtdOrder; i++)
            {
                string prodName;
                double prodPrice;
                int prodQtd;
                Product product;
                OrderItem orderItem;

                Console.WriteLine("Enter #" + (i + 1) + " item data:");
                Console.Write("Product name: ");
                prodName = Console.ReadLine();
                Console.Write("Product Price: R$");
                prodPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                prodQtd = int.Parse(Console.ReadLine());

                product = new Product(prodName, prodPrice);
                orderItem = new OrderItem(prodQtd, prodPrice, product);

                order.AddItem(orderItem);

                Console.WriteLine();
                
            }

            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order);

            Console.ReadLine();
        }
    }
}
