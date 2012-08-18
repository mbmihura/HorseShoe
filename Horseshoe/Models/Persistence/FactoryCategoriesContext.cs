using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Exceptions;
using System.Collections;
using Horseshoe.Models.Configuration;

namespace Horseshoe.Models.Persistence
{
    class FactoryCategoriesContext : IEnumerable
    {
        List<FactoryCategory> itemCategories = new List<FactoryCategory>();
        public List<ItemAbstractFactory> getAllFactories()
        {
            List<ItemAbstractFactory> all = new List<ItemAbstractFactory>();
            foreach (FactoryCategory category in itemCategories)
            {
                all.AddRange(category);
            }
            return all;
        }
        public FactoryCategory Create(string name)
        {
            if (itemCategories.Exists(c => c.Name == name))
            {
                throw new ItemCategoryNameAlreadyUsedException();
            }
            else
            {
                FactoryCategory category = new FactoryCategory(name);
                itemCategories.Add(category);
                return category;
            }
        }
        public void Remove(string categoryName)
        {
            itemCategories.RemoveAll(c => c.Name == categoryName);
        }
        public IEnumerator GetEnumerator()
        {
            return itemCategories.GetEnumerator();
        }
        public static FactoryCategoriesContext LoadTestData()
        {
            //HACK: Test Data
            FactoryCategoriesContext textContext = new FactoryCategoriesContext();
            FactoryCategory category = textContext.Create("todas");
            new IndependentPriceFactory(category, "Viaje", false,"servicio",500).DescriptionPatern = "{0} viaje a {3}";
            new FixedPriceFactory(category, "Rx", 55.0m, false).DescriptionPatern = "Rx a {0}";
            new PricePerDayFactory(category, "Induccion a la ovulacion", 100, false, 5).DescriptionPatern = "{0} Induccion a la ovulacion";
            new PricePerDayFactory(category, "Tratamiento de prueba con fecha", 100, true,5).DescriptionPatern = "Tratamiento de prueba el dia {2}";
            Dictionary<StayCategory, decimal> prices = new Dictionary<StayCategory, decimal>();
            int i = 5;
            foreach (StayCategory st in Program.StayCategoriesAll)
            {
                prices.Add(st,i);
                i += 14;
            }
            new PricePerCategoryFactory(category, "Desbasada",prices , false).DescriptionPatern = "Desbasada a {0} ({3}).";
            return textContext;
        }
    }
}
