using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
  public  class CustomerManager
    {
        
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + "  adlı müşteri başarıyla eklendi");
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + "  adlı müşteri listeden çıkarıldı");
        }

        public void ListCustomer(Customer[] customers)
        {
            foreach(var item in customers)
            {
                Console.WriteLine(item.Id+ " "+ item.CustomerName+" "+item.CustomerSurname+" "+item.CreditType+" "+item.AccountNumber);
            }
          
        }
    }
}
