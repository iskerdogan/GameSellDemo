using GameSellDemo.Abstract;
using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Concrete
{
    class SalesManager : ISalesService
    {
        public void sell(Customer customer, Game game, Campaign campaign)
        {
            game.GamePrice = game.GamePrice - game.GamePrice * campaign.Amount / 100;
            Console.WriteLine(customer.FirstName + " adlı müşteri " + campaign.CampaignName + " kampanyasından faydalanılarak " + game.GameName + " oyununu " + game.GamePrice + "TL ye satın aldı\n");
        }

        public void sell(Customer customer, Game game)
        {
            Console.WriteLine(customer.FirstName + " adlı müşteri " + game.GameName + " oyununu " + game.GamePrice + "TL ye satın aldı\n");
        }
    }
}
