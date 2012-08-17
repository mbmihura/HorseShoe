using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Horseshoe.Models
{
    class Invoice
    {
        int year;
        byte month;
        
        List<Item> items = new List<Item>();
    }
}
