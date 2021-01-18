using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemo
{
    class CustomerManager
    {

        List<Customer> customers = new List<Customer> { };

        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine("Customer added: " + customer.Name + " " + customer.Surname + (customer.Vip ? "(VIP)" : null));
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine("Customer removed: " + customer.Name + " " + customer.Surname + (customer.Vip ? "(VIP)" : null));
        }

        public void ListAllCustomers()
        {
            foreach( Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Surname + (customer.Vip ? "(VIP)" : null));
            }
        }

    }
}
