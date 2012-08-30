using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Models.Persistence;
using Horseshoe.Models.Configuration;

namespace Horseshoe.Models
{
    class PeriodContext
    {
        public FactoryCategoriesHome ItemFactories { get; private set; }
        public StayCategoriesHome StayCategories { get; private set; }
        public HorsesHome Horses { get; private set; }
        public OwnersHome Owners { get; private set; }

        public static PeriodContext LoadFromFile(string path)
        {
            //TODO: load from file.
            throw new NotImplementedException();
        }

        public static PeriodContext LoadTestData()
        {
            //generate test data
            var stayCategoriesHome = new StayCategoriesHome();
            stayCategoriesHome.Add(new StayCategory("yegua madre", 5m));
            stayCategoriesHome.Add(new StayCategory("madre con cria al pie", 10m));

            //TODO: Test Data
            var factoriesHome = new FactoryCategoriesHome();
            FactoryCategory category = factoriesHome.CreateCategory("todas");
            IndependentPriceFactory.CreateFactoryIn(category, "Viaje", "{0} viaje a {3}", false, "servicio", 500);
            FixedPriceFactory.CreateFactoryIn(category, "Rx", "Rx a {0}", 55.0m, false);
            PricePerDayFactory.CreateFactoryIn(category, "Induccion a la ovulacion", "{0} Induccion a la ovulacion", 100, false, 5);
            PricePerDayFactory.CreateFactoryIn(category, "Tratamiento de prueba con fecha", "Tratamiento de prueba el dia {2}", 100, true, 5);
            Dictionary<StayCategory, decimal> prices = new Dictionary<StayCategory, decimal>();
            int i = 5;
            foreach (StayCategory st in stayCategoriesHome)
            {
                prices.Add(st, i);
                i += 14;
            }
            PricePerCategoryFactory.CreateFactoryIn(category, "Desbasada","Desbasada a {0} ({3}).", prices, false) ;

            i = 0;
            StayCategoryChange[] starray = new StayCategoryChange[stayCategoriesHome.Count];
            foreach (Configuration.StayCategory sc in stayCategoriesHome)
                starray[i++] = new StayCategoryChange(DateTime.Today.AddDays(i), sc);


            //HACK: Test Data
            HorsesHome horsesHome = new HorsesHome();
            List<Owner.OwnerShare> shares = new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) };
            Horse uncaballo = new Horse("horse1",
                true,
                starray[0],
                shares);

            horsesHome.Add(uncaballo);
            horsesHome.Add(new Horse(
                "horse2",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));

            var ownersHome = new OwnersHome();

            return new PeriodContext()
            {
                StayCategories = stayCategoriesHome,
                ItemFactories = factoriesHome,
                Horses = horsesHome,
                Owners = ownersHome
            };

        }
    }
}
