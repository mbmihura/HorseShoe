using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Exceptions;
using System.Collections;
using Horseshoe.Models.Configuration;

namespace Horseshoe.Models.Persistence
{
    class FactoryCategoriesHome : IEnumerable
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
        public FactoryCategory CreateCategory(string name)
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
    }
}
