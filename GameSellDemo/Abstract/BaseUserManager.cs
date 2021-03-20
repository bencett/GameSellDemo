using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Abstract
{
    class BaseUserManager : IPlayerService
    {
        public virtual void AddPlayer(Player player)
        {
            Console.WriteLine("Player added!" + player.PlayerId + player.FirstName);
        }

        public virtual void DeletePlayer(Player player)
        {
            Console.WriteLine("Player deleted!" + player.PlayerId + player.FirstName);
        }

        public virtual void UpdatePlayer(Player player)
        {
            Console.WriteLine("Player updated!" + player.PlayerId + player.FirstName);
        }
    }
}
