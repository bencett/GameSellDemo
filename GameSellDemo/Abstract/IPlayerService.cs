using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Abstract
{
    interface IPlayerService
    {
        void AddPlayer(Player player);
        void DeletePlayer(Player player);
        void UpdatePlayer(Player player);
    }
}
