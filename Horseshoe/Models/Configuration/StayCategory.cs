using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Horseshoe.Models.Configuration
{
    class StayCategory 
    {
        public string Name { get; set; }

        public StayCategory(string name)
        {
            this.Name = name;
        }
    }
}
