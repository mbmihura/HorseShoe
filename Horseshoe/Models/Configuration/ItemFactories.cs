using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Exceptions;
using HorseshoeControls.Input;

namespace Horseshoe.Models.Configuration
{
    abstract class ItemAbstractFactory
    {
        string name;
        //Properties
        public string Name
        { 
            get { return name; }
            set
            {
                Horseshoe.Models.Persistence.FactoryCategoriesContext factoriesContext = Program.ItemCategoriesAll;
                if (factoriesContext != null && factoriesContext.getAllFactories().Exists(s => s.Name == value))
                    throw new FactoryNameAlreadyUsedException();
                else
                    name = value; 
            }
        }
        public FactoryCategory FactoryCategory { get; private set; }
        public string DescriptionPatern { get; set; }
        protected DateType dateType { get; set; }
        //Methods
        public ItemAbstractFactory(FactoryCategory category, string name, bool usePreciseDate)
        {
            Name = name;
            FactoryCategory = category;
            if (usePreciseDate)
            {
                dateType = new UserSetDate();
            }
            else
            {
                dateType = new AutomaticMonth();
            }
            category.Add(this);
        }
        public override string ToString() {return Name; }
        public string getCategory() {return FactoryCategory.Name;}
        public virtual void ConfigureInput(UserInterface userInterface)
        {
            userInterface.Clear();
            dateType.ConfigureInput(userInterface);
        }
        public abstract Item Create(UserInterface userInterface);

        //Nested Classes: DateType Hierarchy
        protected abstract class DateType
        {
            public abstract DateTime Date { get; }
            public abstract void ConfigureInput(UserInterface userInterface);
            public abstract string ToDayMonthString();
        }
        protected class UserSetDate:DateType
        {
            DateInput dateControl;
            public override void ConfigureInput(UserInterface userInterface)
            {
                dateControl = new DateInput();
                userInterface.Show(dateControl);
            }
            public override DateTime Date { get { return dateControl.Selection; }}
            public override string ToDayMonthString()
            {
                return dateControl.Selection.Day + "/" + dateControl.Selection.Month;
            }
        }
        protected class AutomaticMonth:DateType
        {
            DateTime date;
            public override void ConfigureInput(UserInterface userInterface){}
            public override DateTime Date { 
                get
                {
                    date = DateTime.Today;
                    return date;
                }
            }
            public override string ToDayMonthString()
            {
                DateTime date = DateTime.Now;
                return "mes " + date.Month;
            }
        }
    }
   
    class IndependentPriceFactory : ItemAbstractFactory
    {
        TextInput explanationControl;
        NumberInput priceControl;
        public string DefaultExplanation { get; set; }
        public decimal DefaultCost {get; set;}

        public IndependentPriceFactory(FactoryCategory category, string name, bool usePreciseDate, string defaultExplanation, decimal defaultCost)
            : base(category, name, usePreciseDate) 
        {
            DefaultExplanation = defaultExplanation;
            DefaultCost = defaultCost;
        }
        public override void ConfigureInput(UserInterface userInterface)
        {
            base.ConfigureInput(userInterface);
            explanationControl = new TextInput(DefaultExplanation);
            priceControl = new NumberInput(DefaultCost);
            userInterface.Show(explanationControl);
            userInterface.Show(priceControl);
        }
        public override Item Create(UserInterface userInterface)
        {
            string descriptionLiteral = String.Format(DescriptionPatern,
            /*{0}*/ userInterface.Horse,
            /*{1}*/ Name,//TODO: Isn,t better to put factory category???
            /*{2}*/ dateType.ToDayMonthString(),
            /*{3}*/ explanationControl.Text);
            Item product = new Item(userInterface.Horse, this, descriptionLiteral, priceControl.Value, dateType.Date);
            userInterface.Clear();
            return product;
        }
    }
    class FixedPriceFactory:ItemAbstractFactory
    {
        public decimal Price { get; set; }

        public FixedPriceFactory(FactoryCategory category, string name, decimal price, bool usePreciseDate)
            : base(category, name, usePreciseDate)
        {
            Price = price;
        }
        public override void ConfigureInput(UserInterface userInterface)
        {
            base.ConfigureInput(userInterface);
        }
        public override Item Create(UserInterface userInterface)
        {
            string descriptionLiteral = String.Format(DescriptionPatern,
                userInterface.Horse,
                Name,
                dateType.ToDayMonthString(),
                Price);
            Item product = new Item(userInterface.Horse, this, descriptionLiteral, Price, dateType.Date);
            userInterface.Clear();
            return product;
        }
    }
    class PricePerDayFactory:ItemAbstractFactory
    {
        NumberInput daysControl;
        public decimal PricePerDay { get; set; }
        public int DefaultDays { get; set; }

        public PricePerDayFactory(FactoryCategory category, string name, decimal pricePerDay, bool usePreciseDate, int defaultDays)
            : base(category, name, usePreciseDate)
        {
            PricePerDay = pricePerDay;
            DefaultDays = defaultDays;
        }
        public override void ConfigureInput(UserInterface userInterface)
        {
            base.ConfigureInput(userInterface);
            daysControl = new NumberInput(DefaultDays);
            daysControl.DecimalPlaces = 0;
            userInterface.Show(daysControl);
        }
        public override Item Create(UserInterface userInterface)
        {
            string descriptionLiteral = String.Format(DescriptionPatern,
                userInterface.Horse,
                Name,
                dateType.ToDayMonthString(),
                PricePerDay);
            decimal Cost = PricePerDay * daysControl.Value;
            Item product = new Item(userInterface.Horse, this, descriptionLiteral, Cost, dateType.Date);
            userInterface.Clear();
            return product;
        }
    }
    class PricePerCategoryFactory:ItemAbstractFactory
    {
        Dictionary<StayCategory, decimal> price;

        public PricePerCategoryFactory(FactoryCategory category, string name, Dictionary<StayCategory, decimal> pricesDicctionary, bool usePreciseDate)
            : base(category, name, usePreciseDate)
        {
            price = new Dictionary<StayCategory,decimal>(Program.StayCategoriesAll.Count);
            try
            {
                foreach (StayCategory sc in Program.StayCategoriesAll)
                {
                    price.Add(sc, pricesDicctionary[sc]);
                }
            }
            catch (KeyNotFoundException)
            {
                throw new StayCategoryWithNoCostPriceException();
            }
        }
        public override void ConfigureInput(UserInterface userInterface)
        {
            base.ConfigureInput(userInterface);
        }
        public override Item Create(UserInterface userInterface)
        {
            StayCategory stayCategory = userInterface.Horse.ActualStayCategory;
            string descriptionLiteral = String.Format(DescriptionPatern,
                userInterface.Horse,
                Name,
                dateType.ToDayMonthString(),
                stayCategory );
            decimal Cost = price[stayCategory];
            Item product = new Item(userInterface.Horse, this, descriptionLiteral, Cost, dateType.Date);
            userInterface.Clear();
            return product;
        }
    }
    //class PricePerCategoryPerDayFactory : ItemAbstractFactory
    //{
        
    //}
}
