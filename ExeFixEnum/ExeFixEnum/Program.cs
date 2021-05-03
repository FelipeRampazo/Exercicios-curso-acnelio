using System;
using System.Globalization;
using ExeFixEnum.Entities;
using ExeFixEnum.Entities.Enum;
namespace ExeFixEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter client data: ");
            // recebe os dados do cliente 
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY) ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            // cria o cliente 
            Client client = new Client { Name = name,
                Email = email,
                BirthDate = birthDate };
            // recebe os dados do pedido
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = OrderStatus.Parse<OrderStatus>(Console.ReadLine());

            DateTime orderDate = DateTime.Now;
            // cria o pedido e ja coloca o cliente nele 
            Order order = new Order(orderDate, orderStatus, client);

            // começa a pegar os itens 
            Console.Write("How many items to this order ? :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.AddItem(orderItem);

            }

            Console.WriteLine(order.ToString());


        }
    }
}
