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
        public FactoryGroupsHome FactoriesGroups { get; private set; }
        public StayCategoriesHome StayCategories { get; private set; }
        public HorsesHome Horses { get; private set; }
        public OwnersHome Owners { get; private set; }

        public void LoadFromFile(string path)
        {
            //TODO: load from file.
            throw new NotImplementedException();
        }

        public void LoadTestData()
        {
            //Test Data: Estadias
            StayCategories = new StayCategoriesHome();
            StayCategories.Add(new StayCategory("yegua madre", 5m));
            StayCategories.Add(new StayCategory("madre con cria al pie", 10m));

            //Test Data: Grupo de rubros
            FactoriesGroups = new FactoryGroupsHome();
            FactoryGroup group = FactoriesGroups.CreateGroup("todas");

            //Test Data: llenar grupo con rubros
            //TODO: posible refactor group.createFactory(IndependentPriceFac, "viajes"....)
            IndependentPriceFactory.CreateFactoryIn(group, "Viaje", "{0} viaje a {3}", false, "servicio", 500);
            FixedPriceFactory.CreateFactoryIn(group, "Rx", "Rx a {0}", 55.0m, false);
            PricePerDayFactory.CreateFactoryIn(group, "Induccion a la ovulacion", "{0} Induccion a la ovulacion", 100, false, 5);
            PricePerDayFactory.CreateFactoryIn(group, "Tratamiento de prueba con fecha", "Tratamiento de prueba el dia {2}", 100, true, 5);
            Dictionary<StayCategory, decimal> prices = new Dictionary<StayCategory, decimal>();
            int i = 5;
            foreach (StayCategory st in StayCategories)
            {
                prices.Add(st, i);
                i += 14;
            }
            PricePerCategoryFactory.CreateFactoryIn(group, "Desbasada","Desbasada a {0} ({3}).", prices, false) ;


            StayCategoryChange[] starray = new StayCategoryChange[StayCategories.Count];
            i = 0;
            foreach (StayCategory sc in StayCategories)
                starray[i++] = new StayCategoryChange(DateTime.Today.AddDays(i), sc);


            //HACK: Test Data
            Horses = new HorsesHome();
            List<Owner.OwnerShare> shares = new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) };
            Horse uncaballo = new Horse("horse1",
                true,
                starray[0],
                shares);

            Horses.Add(uncaballo);
            Horses.Add(new Horse(
                "Lucky Day",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Luchi",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Orage Candy",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Linda Farra",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "La Notera",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Indiga Farra",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Inca Iberica",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Western Gaucha",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Tania",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Teen Queen",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Persuadora",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Magical Cat",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Miss Peregrina",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Evartina",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Van Roar",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Milagroso Way",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Mackiavelli",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Mr Edu",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Kentuky Wildcat",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Incasico",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Shy Marchade",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Lamb Ride",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Maracutaia",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Kukusita",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Sweet Thunder",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Bohemia",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Evestidra",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Bolola",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Cangas",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Leoti",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "Mill Rain",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));
            Horses.Add(new Horse(
                "La Gata Negra",
                true,
                starray[1],
                new List<Owner.OwnerShare>() { new Owner.OwnerShare(new Owner.Owner(), 100) }
                ));



            Owners = new OwnersHome();
        }
    }
}
