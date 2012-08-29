using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Exceptions;

namespace Horseshoe.Models.Owner
{
    struct OwnerShare
    {
        Owner owner;
        float percentage;
        
        public Owner Owner { get { return owner; } private set { owner = value; } }
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
            //requiered initialization
            this.owner = new Owner();
            this.percentage = 0;
            //Applies Property logic
            Owner = owner;
            Percentage = percentage;
        }
    }
}
