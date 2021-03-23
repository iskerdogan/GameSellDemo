using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Abstract
{
    class BaseGameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine(game.GameName + "Başarıyla Eklendi.\n");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine(game.GameName + "Başarıyla Silindi.\n");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine(game.GameName + "Başarıyla Güncellendi.\n");
        }
    }
}
