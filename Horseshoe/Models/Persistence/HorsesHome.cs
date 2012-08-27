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
            int i = 0;
            Configuration.StayCategory[] starray = new Configuration.StayCategory[Program.StayCategoriesAll.Count];
            foreach (Configuration.StayCategory sc in Program.StayCategoriesAll)
                starray[i++] = sc;


            //HACK: Test Data
            HorsesHome horses = new HorsesHome();
            List<Owner.OwnerShare> shares = new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) };
            Horse uncaballo = new Horse("horse1",
                true,
                starray[0],
                shares);

            horses.Add(uncaballo);
            horses.Add(new Horse(
                "horse2",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            return horses;
        }
    }
}
