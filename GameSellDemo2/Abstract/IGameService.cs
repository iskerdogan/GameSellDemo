using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Abstract
{
    interface IGameService
    {
        void AddGame(Game game);
        void DeleteGame(Game game);
        void UpdateGame(Game game);
    }
}
