using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Abstract
{
    interface IUserCheckService
    {
        public bool CheckIfRealPerson(Player player);
    }
}
