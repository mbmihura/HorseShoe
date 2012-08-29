using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Horseshoe.Models.Configuration
{
    class StayCategory
    {
        public string Name { get; set; }
        public decimal PricePerDay { get; set; }
        public bool ValidForMale { get; set; }
        public bool ValidForFemale { get; set; }

        public StayCategory(string name, decimal pricePerDay, bool validForMale = true,bool validForFemale = true)
        {
            this.Name = name;
            this.PricePerDay = pricePerDay;
            this.ValidForMale = validForMale;
            this.ValidForFemale = validForFemale;
        }
        public StayCategoryChange Create()
        {
            throw new NotImplementedException();
        }

        internal bool ValidateSex(bool isMale)
        {
            return isMale && ValidForMale || !isMale && ValidForFemale;
        }
    }
}
