using GameSellDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Concrete
{
    class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
