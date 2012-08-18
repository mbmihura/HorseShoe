using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Exceptions;

namespace Horseshoe.Models.Owner
{
    class OwnerShare
    {
        float percentage;
        public Owner Owner { get; private set; }
        public float Percentage
        {
            get { return percentage; }
            set
            {
                if (value < 0 || value > 100)
                    throw new SharePercentageOutOfRangeException();
                else
                    percentage = value;
            }
        }
        public OwnerShare(Owner owner, float  percentage)
        {
            Owner = owner;
            Percentage = percentage;
        }
    }
}
