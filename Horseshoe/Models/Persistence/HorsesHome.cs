using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Horseshoe.Models.Persistence
{
    class HorsesHome:List<Horse>
    {
        public static HorsesHome LoadTestData()
        {
            //HACK: Test Data
            HorsesHome horses = new HorsesHome();
            horses.Add(new Horse(
                "horse1",
                true,
                (Configuration.StayCategory)Program.StayCategoriesAll.GetEnumerator().Current,
                new List<Owner.OwnerShare>(){new Owner.OwnerShare(new Owner.Owner(),100)}
                ));
            horses.Add(new Horse(
                "horse2",
                true,
                (Configuration.StayCategory)Program.StayCategoriesAll.GetEnumerator().Current,
                new List<Owner.OwnerShare>(){new Owner.OwnerShare(new Owner.Owner(),100)}
                ));
            return horses;
        }
    }
}
