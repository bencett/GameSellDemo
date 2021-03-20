using GameSellDemo.Abstract;
using GameSellDemo.Concrete;
using GameSellDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.PlayerId = 1;
            player1.nationalityId = 27215594094;
            player1.FirstName = "Çetin";
            player1.LastName = "Ürün";

            PlayerManager playerManager = new PlayerManager();
            playerManager.AddPlayer(new Player 
            { 
                DateOfBirth = new DateTime(1999,04,22),
                FirstName="Çetin",LastName="Ürün",nationalityId=12345678910,PlayerId=1
            });
            Console.WriteLine(playerManager);
            
            
            Game game1 = new Game();
            game1.GameName = "Grand Theft Auto V";
            game1.GamePrice = 450;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignType = "Black Friday";

           

            GameSellManager gameSellManager = new GameSellManager();
            gameSellManager.SellNormal(player1,game1);
        }
    }
}
