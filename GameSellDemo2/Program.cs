using GameSellDemo.Abstract;
using GameSellDemo.Adapters;
using GameSellDemo.Concrete;
using GameSellDemo.Entites;
using System;

namespace GameSellDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Erdoğan";
            customer.LastName = "IŞIK";
            customer.DateOfBirth = new DateTime(1999, 09, 02);
            customer.IdentificationNumber = "12345678910";
            BaseCustomerManager baseCustomerManager = new BaseCustomerManager(new MernisServiceAdapter());
            baseCustomerManager.AddPlayer(customer);

            Game game = new Game();
            game.Id = 1;
            game.GameName = "İlk Oyun";
            game.GamePrice = 550;
            BaseGameManager gameManager = new BaseGameManager();
            gameManager.AddGame(game);

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "Hoşgeldin indirimi";
            campaign.Amount = 15;

            SalesManager salesManager = new SalesManager();
            salesManager.sell(customer, game);
            salesManager.sell(customer, game, campaign);
        }
    }
}
