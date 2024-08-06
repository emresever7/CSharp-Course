using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class CustomerManager
    {

        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer{Id=1, FirstName="Emre", LastName="Sever", City="Kastamonu", Email="emre@gmail.com"},
                new Customer{Id=2, FirstName="Ahmet", LastName="Sever", City="İstanbul", Email="ahmet@gmail.com"},
                new Customer{Id=3, FirstName="Mehmet", LastName="Sever", City="İzmir", Email="mehmet@gmail.com"},
                new Customer{Id=4, FirstName="Neriman", LastName="Sever", City="İstanbul", Email="neriman@gmail.com"},
                new Customer{Id=5, FirstName="İlay", LastName="Ayhan", City="Ankara", Email="ilay@gmail.com"},
                new Customer{Id=6, FirstName="Ayaz", LastName="Ayhan", City="Kastamonu", Email="ayaz@gmail.com"}
            };

        }

        List<Customer> customers;
        public List<Customer> GetAll()
        {
            
            return customers;
        }

        public void Add(Customer customer) 
        {
            customers.Add(customer);
        }
    }
}
