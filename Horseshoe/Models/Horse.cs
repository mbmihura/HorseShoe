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
        ICollection<OwnerShare> owners = new List<OwnerShare>();
        List<StayCategoryChange> staysCategoryHistory = new List<StayCategoryChange>();

        public ICollection<OwnerShare> Owners
        {
            get { return owners; }
            set
            {
                //Checks that shares add to a 100%.
                if (value.Aggregate(0f, (sum, share) => sum + share.Percentage) != 100)
                    throw new SharesPercentageSumNot100Exception();
                owners = value;
            }

        }
        public List<StayCategoryChange> StaysCategoryHistory
        {
            get { return staysCategoryHistory; }
        }
        public StayCategory ActualStayCategory 
        {
            //returns the stayCatagory of the newest stayChange(fisrt) of the list.
            get {return staysCategoryHistory.First().StayCategory;}
        }
        

        public Horse(string name, bool isMale, StayCategoryChange initialStayCategoryChange, ICollection<OwnerShare> ownerShareList)
        {
            //Initialize a Horse, applying business rules.
            Name = name;
            Male = isMale;
            AddStayCategoryChange(initialStayCategoryChange);
            Owners = ownerShareList;
        }
            
        public void AddStayCategoryChange(StayCategoryChange stayCategoryChange)
        {
            //Validate that category is aplicable to horse sex.
            if (stayCategoryChange.StayCategory.ValidateSex(Male))
            {
                //Checks that there is only on stayCatChange per day
                if (staysCategoryHistory.Exists(s => s.Day.Date == stayCategoryChange.Day.Date))
                {
                    throw new AlreadyExistsStayCategoryChangeThatDayException();
                }
                //Keeps stayHistory sorted by Day (desc). Finds the first occurrence of a older stay...
                int position = staysCategoryHistory.FindIndex(s => s.Day.Date < stayCategoryChange.Day.Date);
                //If there is no occurence, element is insert fisrt.
                if (position == -1)
                    position = 0; 
                staysCategoryHistory.Insert(position,stayCategoryChange);
            }
            else {
                throw new CategoryNotApplicableToHorseSex();
            }

        }
        public override string ToString() {return Name;}
    }
}
