using GameSellDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Abstract
{
    interface IGameSellService
    {
        void SellNormal(Player player, Game game);
        void SellWithCampaign(Player player, Game game, Campaign campaign);
    }
}
