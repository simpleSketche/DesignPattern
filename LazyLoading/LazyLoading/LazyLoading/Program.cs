using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LazyLoading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine(customer.CustomerName); // orders not loaded yet

            foreach (Order order in customer.Orders) // orders loaded
            {
                Console.WriteLine(order.orderId);
            }
            Console.Read();
        }
    }

    public class Customer
    {
        private Lazy<List<Order>> _Orders = null;

        public Customer()
        {
             CustomerName = "Yankun";
            _Orders = new Lazy<List<Order>>(() => LoadOrders());
        }

        public string CustomerName { get; set; }

        public List<Order> Orders
        {
            get
            {
                return _Orders.Value;
            }
        }

        private List<Order> LoadOrders()
        {
            List<Order> tempOrders = new List<Order>();
            for (int i = 0; i < 10; i++)
            {
                Order newOrder = new Order();
                newOrder.orderId = "A00" + i.ToString();
                tempOrders.Add(newOrder);
                Thread.Sleep(5000);
            }

            return tempOrders;
        }

    }

    public class Order
    {

        public Order()
        {
        }
        public string orderId { get; set; }
    }

}
