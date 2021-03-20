using GameSellDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Abstract
{
    interface ICampaignService
    {
        void AddCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
    }
}
