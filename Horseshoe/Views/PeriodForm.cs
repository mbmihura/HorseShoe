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
            var horses = Program.Context.Horses;
            var types = Program.Context.FactoriesGroups.getAllFactories();
            itemsInputView.TypeDataSource = types;
            itemsInputView.HorseDataSource = horses;
            stayChangeView.TypeDataSource = types;
            stayChangeView.HorseDataSource = horses;
        }

        private void optPeriodHorses_lbl_Click(object sender, EventArgs e)
        {
            
        }

        private void optBill_lbl_Click(object sender, EventArgs e)
        {
            new BillingForm().ShowDialog();
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show("Form.KeyPress: '" +
                    e.KeyChar.ToString() + "' pressed.");

                switch (e.KeyChar)
                {
                    case (char)49:
                    case (char)52:
                    case (char)55:
                        MessageBox.Show("Form.KeyPress: '" +
                            e.KeyChar.ToString() + "' consumed.");
                        e.Handled = true;
                        break;
                }
            }
        }

        private void Show_StayChangeView(object sender, EventArgs e)
        {
            stayChangeView.Show();
            itemsInputView.Hide();
        }

        private void Show_ItemInputView(object sender, EventArgs e)
        {
            stayChangeView.Hide();
            itemsInputView.Show();
        }

    }
}
