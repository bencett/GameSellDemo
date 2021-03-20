using GameSellDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo
{
    class Player:IEntity
    {
        public int PlayerId { get; set; }
        public long nationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
