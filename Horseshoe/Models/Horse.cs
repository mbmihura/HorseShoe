using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Models.Owner;
using Horseshoe.Models.Configuration;
using Horseshoe.Exceptions;

namespace Horseshoe.Models
{
    class Horse
    {
        public string Name { get; set; }
        public bool Male { get; set; }
        public StayCategory StayCategory { get; private set; }
        ICollection<OwnerShare> owners = new List<OwnerShare>();
        List<StayCategoryChange> staysCategoryHistory = new List<StayCategoryChange>();
        public void ChangeStayCategory(StayCategoryChange stayCategoryChange)
        {
            if (stayCategoryChange.StayCategory.ValidateSex(Male))
            {
                staysCategoryHistory.Add(stayCategoryChange);
                StayCategory = stayCategoryChange.StayCategory;
            }
            else {
                throw new CategoryNotApplicableToHorseSex();
            }

        }
        public override string ToString()
        {
            return Name;
        }
    }
}
