using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
   public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CustomerName = "özge";
            customer1.CustomerSurname = "bektaş";
            customer1.CreditType = "konut kredisi";
            customer1.AccountNumber = "123456789";


            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.CustomerName = "kübra";
            customer2.CustomerSurname = "topal";
            customer2.CreditType = "araba kredisi";
            customer2.AccountNumber = "055412486";

            Customer customer3 = new Customer();
            customer3.Id = 1;
            customer3.CustomerName = "yaren";
            customer3.CustomerSurname = "uygun";
            customer3.CreditType = "ihtiyaç kredisi";
            customer3.AccountNumber = "5641657132";


            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            Console.WriteLine("ekleme işlemi.......");
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);
            Console.WriteLine("silme işlemi.........");
            customerManager.DeleteCustomer(customer1);
            customerManager.DeleteCustomer(customer2);
            customerManager.DeleteCustomer(customer3);
            Console.WriteLine("listeleme işlemi");
            customerManager.ListCustomer(customers);

        }
    }
}
