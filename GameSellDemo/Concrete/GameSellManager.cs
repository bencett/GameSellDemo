using GameSellDemo.Abstract;
using GameSellDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Concrete
{
    class GameSellManager : IGameSellService
    {
        public void SellNormal(Player player, Game game)
        {
            Console.WriteLine("Sevgili "+ player.FirstName + player.LastName + ", almış olduğunuz" + 
                game.GameName + "oyununu iyi günlerde kullanmanızı dileriz. Oyun ücreti : "+ game.GamePrice);
        }

        public void SellWithCampaign(Player player, Game game, Campaign campaign)
        {
            Console.WriteLine("Sevgili " + player.FirstName + player.LastName + ", almış olduğunuz" +
                game.GameName + " oyununu "+ campaign.CampaignType +" kampanyası dahilinde " + game.GamePrice 
                + " TL ödeyerek satın aldınız. İyi oyunlar dileriz.");
        }
    }
}
