using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Horseshoe.Views
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void optPeriodHorses_lbl_Click(object sender, EventArgs e)
        {
            PeriodForm newMDIChild = new PeriodForm();
               // Set the Parent Form of the Child window.
               newMDIChild.MdiParent = this.MdiParent;
               // Display the new form.
               newMDIChild.Show();
        }
    }
}
