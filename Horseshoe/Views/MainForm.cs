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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PeriodForm newMDIChild = new PeriodForm();
               // Set the Parent Form of the Child window.
               // Display the new form.
               newMDIChild.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void il_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
