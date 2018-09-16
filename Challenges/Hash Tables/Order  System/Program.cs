using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem
{
    public class Order
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Consumer { get; set; }

        public Order(string name, double price, string consumer)
        {
            this.Name = name;
            this.Price = price;
            this.Consumer = consumer;
        }

        public override string ToString()
        {
            return string.Format("{{" + $"{this.Name};{this.Consumer};{this.Price:F2}" + "}}");
        }
    }

    public class Program
    {
        private static HashSet<Order> orders = new HashSet<Order>();

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var builder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, 2);
                string command = input.First();
                string[] args = input.Last().Split(';');

                string name;
                double price;
                string consumer;
                string message = string.Empty;
                switch (command)
                {
                    case "AddOrder":
                        name = args[0];
                        price = double.Parse(args[1]);
                        consumer = args[2];

                        message = AddOrder(name, price, consumer);
                        builder.AppendLine(message);
                        break;
                    case "DeleteOrders":
                        consumer = args[0];

                        message = DeleteOrders(consumer);
                        builder.AppendLine(message);
                        break;
                    case "FindOrdersByPriceRange":
                        double fromPrice = double.Parse(args[0]);
                        double toPrice = double.Parse(args[1]);

                        message = FindOrdersByPriceRange(fromPrice, toPrice);
                        builder.AppendLine(message);
                        break;
                    case "FindOrdersByConsumer":
                        consumer = args[0];

                        message = FindOrdersByConsumer(consumer);
                        builder.AppendLine(message);
                        break;
                }
            }

            Console.WriteLine(builder.ToString().TrimEnd());
        }

        private static string FindOrdersByConsumer(string consumer)
        {
            List<Order> consumerOrders = orders.Where(x => x.Consumer == consumer)
                .OrderBy(x => x.Name).ToList();

            if (!consumerOrders.Any())
                return "No orders found";

            StringBuilder builder = new StringBuilder();

            foreach (Order item in consumerOrders)
            {
                builder.AppendLine(item.ToString());
            }

            return builder.ToString().TrimEnd();
        }

        private static string FindOrdersByPriceRange(double fromPrice, double toPrice)
        {
            List<Order> pricesRangedOrders = orders.Where(x => x.Price >= fromPrice && x.Price <= toPrice)
                .OrderBy(x => x.Name).ToList();

            if (!pricesRangedOrders.Any())
                return "No orders found";

            StringBuilder builder = new StringBuilder();

            foreach (Order order in pricesRangedOrders)
            {
                builder.AppendLine(order.ToString());
            }

            return builder.ToString().TrimEnd();
        }

        private static string DeleteOrders(string consumer)
        {
            int countBeforeDel = orders.Count;
            orders = orders.Where(x => x.Consumer != consumer).ToHashSet();
            int countAfterDel = orders.Count;

            int deletedCount = countBeforeDel - countAfterDel;

            if (deletedCount == 0)
                return "No orders found";

            return $"{deletedCount} orders deleted";
        }

        private static string AddOrder(string name, double price, string consumer)
        {
            Order order = new Order(name, price, consumer);

            orders.Add(order);

            return $"Order added";
        }
    }
}