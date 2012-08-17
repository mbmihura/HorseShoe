using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Models.Configuration;

namespace Horseshoe.Models
{
    class Item
    {
        public DateTime Date { get; set; }
        public Horse Horse { get; private set; }
        public ItemAbstractFactory Type { get; private set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public Item(Horse horse,ItemAbstractFactory type, string description, decimal cost, DateTime date)
        {
            this.Horse = horse;
            this.Type = type;
            this.Description = description;
            this.Cost = cost;
            this.Date = date;
        }
    }
}
