using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Models.Configuration;

namespace Horseshoe.Models
{
    class StayCategoryChange
    {
        public DateTime Day { get; set; }
        public StayCategory StayCategory { get; set; }
        public StayCategoryChange(DateTime dayOfChange, StayCategory newCategory)
        {
            Day = dayOfChange;
            StayCategory = newCategory;
        }
    }
}
