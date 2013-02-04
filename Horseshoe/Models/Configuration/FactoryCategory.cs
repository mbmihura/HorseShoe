using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Horseshoe.Models.Configuration
{
    class FactoryGroup : List<ItemAbstractFactory>
    {
        public string Name { get; set; }

        public FactoryGroup(string name):base()
        {
            this.Name = name;
        }
    }
}
