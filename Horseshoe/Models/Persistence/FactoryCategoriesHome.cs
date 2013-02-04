using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Exceptions;
using System.Collections;
using Horseshoe.Models.Configuration;

namespace Horseshoe.Models.Persistence
{
    class FactoryGroupsHome : IEnumerable
    {
        List<FactoryGroup> itemCategories = new List<FactoryGroup>();
        public List<ItemAbstractFactory> getAllFactories()
        {
            List<ItemAbstractFactory> all = new List<ItemAbstractFactory>();
            foreach (FactoryGroup category in itemCategories)
            {
                all.AddRange(category);
            }
            return all;
        }
        public FactoryGroup CreateGroup(string name)
        {
            if (itemCategories.Exists(c => c.Name == name))
            {
                throw new ItemCategoryNameAlreadyUsedException();
            }
            else
            {
                FactoryGroup category = new FactoryGroup(name);
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
