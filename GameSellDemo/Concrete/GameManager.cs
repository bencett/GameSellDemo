using GameSellDemo.Abstract;
using GameSellDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Concrete
{
    class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("Game updated!");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine("Game deleted!");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine("Game updated!");
        }
    }
}
