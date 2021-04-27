using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> lstcust = new List<Customer>();
            lstcust.Add(new Customer() { name = "Dipesh", address = "USA" });
            lstcust.Add(new Customer() { name = "Rajesh", address = "India" });
            lstcust.Add(new Customer() { name = "Sagar", address = "India" });
            lstcust.Add(new Customer() { name = "Guarang", address = "USA" });

            var cust = lstcust.Where(c => c.address.ToString() == "USA");


            foreach (var item in cust)
            {
                Console.WriteLine(item.name);
            }
            Console.WriteLine(cust.Count());
            Console.ReadLine();
        }
        public class Customer
        {
            public string name = "";
            public string address = "";
        }
    }
}
