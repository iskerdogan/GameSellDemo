using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Abstract
{
    interface ISalesService
    {
        void sell(Customer customer, Game game, Campaign campaign);
        void sell(Customer customer, Game game);


    }
}
