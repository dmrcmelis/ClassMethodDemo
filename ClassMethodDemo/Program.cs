using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Sedat";
            customer1.Age = 32;
            customer1.Job = "Teacher";
            customer1.AccountLimit = 5000;

            Customer customer2 = new Customer();
            customer2.Name = "Ezgi";
            customer2.Age = 25;
            customer2.Job = "doctor";
            customer2.AccountLimit = 7500;

            Customer customer3 = new Customer();
            customer3.Name = "Melis";
            customer3.Age = 23;
            customer3.Job = "Engineer";
            customer3.AccountLimit = 7500;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Age);
                Console.WriteLine(customer.Job);
                Console.WriteLine(customer.AccountLimit);
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.List();
            customerManager.Del();






            
        }
    }
}
