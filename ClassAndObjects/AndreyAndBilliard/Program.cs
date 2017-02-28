    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var products = new Dictionary<string, decimal>();
            
            for (int i = 0; i < n; i++)
            {
                var inputProducts = Console.ReadLine().Split('-');

                string productName = inputProducts[0];
                decimal productPrice = decimal.Parse(inputProducts[1]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, productPrice);
                }

                products[productName] = productPrice;

            }

            var line = Console.ReadLine();

            List<Customer> customers = new List<Customer>();

            while (!line.Equals("end of clients"))
            {
                string[] customerInfo = line.Split('-', ',');

                string customerName = customerInfo[0];
                string customerProduct = customerInfo[1];
                int quantity = int.Parse(customerInfo[2]);
                
                if (!products.ContainsKey(customerProduct))
                {
                    line = Console.ReadLine();
                    continue;
                }

                if (customers.Any(x => x.Name == customerName))
                {
                    Customer customer = customers.First(x => x.Name == customerName);
                    
                    if (!customer.Products.ContainsKey(customerProduct))
                    {
                        customer.Products.Add(customerProduct, quantity);
                    }
                    else
                    {
                        customer.Products[customerProduct] += quantity;
                    }

                   customer.Bill += quantity * products[customerProduct];
                    
                }
                else
                {
                    Customer customer = new Customer();
                    customer.Name = customerName;
                    customer.Products = new Dictionary<string, int>();
                    customer.Products.Add(customerProduct, quantity);
                    customer.Bill += quantity * products[customerProduct];
                    customers.Add(customer);
                }
                

                line = Console.ReadLine();
            }

            

            foreach (var customer in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{customer.Name}");
                foreach (var prod in customer.Products)
                {
                    Console.WriteLine($"-- {prod.Key} - {prod.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }

            decimal totalBill = customers.Sum(x => x.Bill);

            Console.WriteLine("Total bill: {0:f2}", totalBill);
            
        }
    }
    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string , int> Products {get; set;}

        public decimal Bill { get; set; }
    }
}
