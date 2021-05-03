using ExeFixEnum.Entities.Enum;
using ExeFixEnum.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExeFixEnum.Entities
{
    class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime momment, OrderStatus status, Client client)
        {
            Momment = momment;
            Status = status;
            Client = client;
        }



        public void AddItem(OrderItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            items.Add(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder St = new StringBuilder();

            St.AppendLine("Order Sumary");
            St.Append("Order moment");
            St.AppendLine(Momment.ToString());
            St.Append("Order Status: ");
            St.AppendLine(Status.ToString());
            St.Append("Client: ");
            St.Append(Client.Name.ToString());
            St.Append(" ");
            St.Append(Client.BirthDate.Date.ToString());
            St.Append(" - ");
            St.AppendLine(Client.Email.ToString());
            St.AppendLine("Order items:");
            
            foreach (OrderItem items in items)
            {
                St.Append(items.Product.Name.ToString());
                St.Append(", ");
                St.Append(items.Price.ToString());
                St.Append(",  Quantity: ");
                St.Append(items.Quantity.ToString());
                St.Append(", SubTotal:  $");
                St.AppendLine(items.SubTotal().ToString("F2", CultureInfo.InvariantCulture));            
            }

            St.Append("Total price: $");
            St.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));


            return St.ToString();
        }
    }
}
