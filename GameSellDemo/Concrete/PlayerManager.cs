using GameSellDemo.Abstract;
using GameSellDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Concrete
{
    class PlayerManager : IPlayerService
    {
        public IUserCheckService _userCheckService;
        public PlayerManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }
        public void AddPlayer(Player player)
        {
                Console.WriteLine("Player added!" + player.PlayerId + player.FirstName);
        }

        public void DeletePlayer(Player player)
        {
            Console.WriteLine("Player deleted!" + player.PlayerId + player.FirstName);
        }

        public void UpdatePlayer(Player player)
        {
            Console.WriteLine("Player updated!" + player.PlayerId + player.FirstName);
        }
    }
}
