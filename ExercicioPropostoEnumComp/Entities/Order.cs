using System;
using System.Collections.Generic;
using System.Text;
using ExercicioPropostoEnumComp.Entities.Enums;

namespace ExercicioPropostoEnumComp.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(Client client, OrderStatus status)
        {
            this.Client = client;
            this.Moment = DateTime.Now;
            this.Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            
            
        }


    }
}
