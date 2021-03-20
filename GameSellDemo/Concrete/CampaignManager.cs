using GameSellDemo.Abstract;
using GameSellDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign added!");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted!");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign updated!");
        }
    }
}
