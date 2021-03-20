using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Entities
{
    class Game:IEntity
    {
        public string GameId { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}
