using System;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)


        {
            

            Customer customer1 = new Customer() { Id = 101, Name = "Serkan", Surname = "Okur", Vip = false };
            Customer customer2 = new Customer() { Id = 102, Name = "Uzay", Surname = "Okur", Vip = true };
            Customer customer3 = new Customer() { Id = 103, Name = "Erkan", Surname = "Okur", Vip = true };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("-------------------------");

            customerManager.Remove(customer2);

            Console.WriteLine("-------------------------");

            Console.WriteLine("Our customers:");
            customerManager.ListAllCustomers();


        }
    }
}
