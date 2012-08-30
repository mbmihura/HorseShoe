using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Models.Persistence;

namespace Horseshoe.Models
{
    class PeriodContext
    {
        public FactoryCategoriesHome ItemCategoriesAll { get; private set; }
        public StayCategoriesHome StayCategoriesAll { get; private set; }
        public HorsesHome HorsesAll { get; private set; }
        public OwnersHome OwnersAll { get; private set; }

        public static PeriodContext LoadFromFile(string path)
        {
            //TODO: load from file.
            throw new NotImplementedException();
        }

        public static PeriodContext LoadTestData()
        {
            return new PeriodContext()
            {
                StayCategoriesAll = StayCategoriesHome.LoadTestData(),
                ItemCategoriesAll = FactoryCategoriesHome.LoadTestData(),
                HorsesAll = HorsesHome.LoadTestData(),
                OwnersAll = OwnersHome.LoadTestData()
            };

        }
    }
}
