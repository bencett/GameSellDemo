using GameSellDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Adapters
{
    class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(player.NationalityId), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year, player.DateOfBirth.Month, player.DateOfBirth.Day);
        }
    }
}

    
