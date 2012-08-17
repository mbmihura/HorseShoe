using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Models.Owner;
using Horseshoe.Models.Configuration;

namespace Horseshoe.Models
{
    class Horse
    {
        public string Name { get; set; }
        bool male;
        StayCategory StayCat { get; set; }
        ICollection<OwnerShare> owners = new List<OwnerShare>();
        ICollection<Stay> stays = new List<Stay>();
        ICollection<Item> historyCosts = new List<Item>();
        ICollection<Item> actualcosts = new List<Item>();

        public override string ToString()
        {
            return Name;
        }

        internal Configuration.StayCategory GetStayCategory()
        {
            return StayCat;
        }
    }
}
