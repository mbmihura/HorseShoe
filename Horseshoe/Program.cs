using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Horseshoe.Models.Configuration;

namespace Horseshoe
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        private static FactoryCategoriesContext itemCategories = new FactoryCategoriesContext();
        private static StayCategoriesContext stayCategories;

        public static FactoryCategoriesContext ItemCategories { get { return itemCategories; } }
        public static StayCategoriesContext StayCategories { get { return stayCategories; } }


        [STAThread]
        static void Main()
        {
            stayCategories = StayCategoriesContext.Load();
            itemCategories = FactoryCategoriesContext.Load();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
