using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Abstract
{
    public interface ICustomerService
    {
        void AddPlayer(Customer customer);
        void DeletePlayer(Customer customer);
        void UpdatePlayer(Customer customer);
    }
}
