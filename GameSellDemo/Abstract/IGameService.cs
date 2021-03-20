using GameSellDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Abstract
{
    interface IGameService
    {
        void AddGame(Game game);
        void DeleteGame(Game game);
        void UpdateGame(Game game);
    }
}
