using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Horseshoe.Models.Owner
{
    class Email : IBillingDeliveryMethod
    {
        string email;
        void IBillingDeliveryMethod.Bill() 
        {

        }
    }
}
