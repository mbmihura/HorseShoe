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

        public Horse(string name, bool isMale, StayCategory initialStayCategory, ICollection<OwnerShare> ownersList)
        {
            //Initialize a Horse...
            Name = name;
            Male = isMale;
            StayCategory = initialStayCategory;
            //Chacks that shares add to a 100%.
            //TODO: refactor so user can edit share n owners.
            if (ownersList.Aggregate(0f, (sum, i) => sum + i.Percentage) != 100)
            {
                throw new SharesPercentageSumNot100Exception();
            }
            else
            {
                owners = ownersList;
            }
        }
            
        public void ChangeStayCategory(StayCategoryChange stayCategoryChange)
        {
            //Change StayCategory (actual) for the new one, and adds to historical records.
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
