using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HorseshoeControls.Input
{
    public partial class DateInput : UserControl
    {
        public DateInput()
        {
            InitializeComponent();
            input_mcal.SelectionStart = DateTime.Now;
            //HACK: verify if its  necesary to load each numericcontrol.
            day_nud.Value = DateTime.Now.Day;
            month_nud.Value = DateTime.Now.Month;
            year_nud.Value = DateTime.Now.Year;
        }
        public string Label
        {
            get { return title_lbl.Text; }
            set { title_lbl.Text = value; }
        }
        public DateTime Selection
        {
            get { return input_mcal.SelectionStart; }
            set { input_mcal.SelectionStart = value; }
        }

        private void day_nud_ValueChanged(object sender, EventArgs e)
        {
            input_mcal.SelectionStart = new DateTime(Convert.ToInt32(year_nud.Value), Convert.ToInt32(month_nud.Value), Convert.ToInt32(day_nud.Value));
        }

        private void month_nud_ValueChanged(object sender, EventArgs e)
        {
            input_mcal.SelectionStart = new DateTime(Convert.ToInt32(year_nud.Value), Convert.ToInt32(month_nud.Value), Convert.ToInt32(day_nud.Value));
        }

        private void year_nud_ValueChanged(object sender, EventArgs e)
        {
            input_mcal.SelectionStart = new DateTime(Convert.ToInt32(year_nud.Value), Convert.ToInt32(month_nud.Value), Convert.ToInt32(day_nud.Value));
        }

        private void input_mcal_DateChanged(object sender, DateRangeEventArgs e)
        {
            day_nud.Value = input_mcal.SelectionStart.Day;
            month_nud.Value = input_mcal.SelectionStart.Month;
            year_nud.Value = input_mcal.SelectionStart.Year;
        }
    }
}
