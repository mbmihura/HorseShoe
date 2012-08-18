using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Horseshoe.Models.Configuration;
using Horseshoe.Views;
using Horseshoe.Models.Persistence;

namespace Horseshoe
{
    static class Program
    {
        public static FactoryCategoriesContext ItemCategoriesAll { get; private set; }
        public static StayCategoriesContext StayCategoriesAll { get; private set; }
        public static HorsesHome HorsesAll { get; private set; }
        public static OwnersHome OwnersAll { get; private set; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ItemCategoriesAll = FactoryCategoriesContext.LoadTestData();
            StayCategoriesAll = StayCategoriesContext.LoadTestData();
            HorsesAll = HorsesHome.LoadTestData();
            OwnersAll = OwnersHome.LoadTestData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
