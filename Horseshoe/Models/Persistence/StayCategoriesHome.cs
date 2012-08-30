using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Exceptions;
using System.Collections;
using Horseshoe.Models.Configuration;

namespace Horseshoe.Models.Persistence
{
    class StayCategoriesHome : List<StayCategory>
    {
        List<StayCategory> stayCategories = new List<StayCategory>();

        public int Count
        {
            get { return stayCategories.Count; }
        }

        public void Add(StayCategory stayCategory)
        {
            if (stayCategories.Exists(c => c.Name == stayCategory.Name))
            {
                throw new StayCategoryNameAlreadyUsedException();
            }
            else
            {
                stayCategories.Add(stayCategory);
            }
        }
        public void Remove(string categoryName)
        {
            stayCategories.RemoveAll(c => c.Name == categoryName);
        }
        public IEnumerator GetEnumerator()
        {
            return stayCategories.GetEnumerator();
        }
        
        public static StayCategoriesHome LoadTestData()
        {
            //HACK: Test Data
            StayCategoriesHome staycontext = new StayCategoriesHome();
            staycontext.Add(new StayCategory("yegua madre",5m));
            staycontext.Add(new StayCategory("madre con cria al pie",10m));
            return staycontext ;
        }
    }
}
