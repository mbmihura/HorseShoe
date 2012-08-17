using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Horseshoe.Models.Configuration
{
    class FactoryCategory : List<ItemAbstractFactory>
    {
        public string Name { get; set; }

        public FactoryCategory(string name):base()
        {
            this.Name = name;
        }
    }
}
