using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Horseshoe.Models;

namespace Horseshoe.Views
{
    public partial class PeriodForm : Form
    {
        public PeriodForm()
        {
            InitializeComponent();
            itemsInputView.TypeDataSource = Program.ItemCategoriesAll.getAllFactories();
            //itemsInputView.DisplayMember = "Name";
            //itemsInputView.ValueMember = null;

            itemsInputView.HorseDataSource = Program.HorsesAll;
            //itemsInputView.DisplayMember = "Name";
            //itemsInputView.ValueMember = null;
        }

        private void optPeriodHorses_lbl_Click(object sender, EventArgs e)
        {
            
        }

        private void optBill_lbl_Click(object sender, EventArgs e)
        {
            new BillingForm().ShowDialog();
        }

    }
}
