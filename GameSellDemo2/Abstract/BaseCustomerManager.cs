using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Abstract
{
    public class BaseCustomerManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;
        public BaseCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void AddPlayer(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer) == true)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " added\n");
            }
            else
            {
                Console.WriteLine("Kimlik Hatası");
            }
        }
        public void DeletePlayer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " deleted");
        }

        public void UpdatePlayer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " updated");
        }
    }
}
