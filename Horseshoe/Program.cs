﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Horseshoe.Models.Configuration;
using Horseshoe.Views;
using Horseshoe.Models;

namespace Horseshoe
{
    static class Program
    {
        public static PeriodContext Context { get; private set; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Context = args.Length > 0 ? PeriodContext.LoadFromFile(args[0]) : PeriodContext.LoadTestData() /*TODO: loadLastKwonPeriodContext*/;
            Application.Run(new PeriodForm());
        }
    }
}
