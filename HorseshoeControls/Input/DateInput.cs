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
            try
            {
                SetDateInCalendarControl();
            }
            catch (ArgumentOutOfRangeException)
            {
                int month = Convert.ToInt32(month_nud.Value);
                int year = Convert.ToInt32(year_nud.Value);
                MessageBox.Show(String.Format("El dia ingresado tiene que estar entre 1 y {0} para {1}.", DateTime.DaysInMonth(year, month), new DateTime(year, month, 1).ToString("MMMM")), "Dia Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                day_nud.Focus();
            }

        }

        private void SetDateInCalendarControl()
        {
            int day = Convert.ToInt32(day_nud.Value);
            int month = Convert.ToInt32(month_nud.Value);
            int year = Convert.ToInt32(year_nud.Value);
            input_mcal.SelectionStart = new DateTime(year, month, day);
        }
        private void year_nud_ValueChanged(object sender, System.EventArgs e)
        {
            SetDateInCalendarControl();
        }

        private void month_nud_ValueChanged(object sender, System.EventArgs e)
        {
            SetDateInCalendarControl();
        }

        private void input_mcal_DateChanged(object sender, DateRangeEventArgs e)
        {
            day_nud.Value = input_mcal.SelectionStart.Day;
            month_nud.Value = input_mcal.SelectionStart.Month;
            year_nud.Value = input_mcal.SelectionStart.Year;
        }

        private void day_nud_Enter(object sender, EventArgs e)
        {
            day_nud.Select(0, day_nud.Value.ToString().Length);
        }

        private void month_nud_Enter(object sender, EventArgs e)
        {
            month_nud.Select(0, month_nud.Value.ToString().Length);
        }

        private void year_nud_Enter(object sender, EventArgs e)
        {
            year_nud.Select(0, year_nud.Value.ToString().Length);
        }
    }
}
