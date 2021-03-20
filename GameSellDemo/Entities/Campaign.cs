using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Entities
{
    class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignType { get; set; }
    }
}
