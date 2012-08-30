using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Horseshoe.Models.Configuration;
using Horseshoe.Models;

namespace Horseshoe
{
    public partial class UserAcceptabilityTestForm : Form
    {
        public UserAcceptabilityTestForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Setup data binding
            factory.DataSource = Program.Context.ItemCategoriesAll.getAllFactories();
            factory.DisplayMember = "Name";
            factory.ValueMember = null;

            hor.DataSource = Program.Context.HorsesAll;
            hor.DisplayMember = "Name";
            hor.ValueMember = null;

            //dataGridView1.DataSource = l;
        }
        ItemAbstractFactory fact;
        UserInterface ui;
        List<Item> l = new List<Item>();
        private void factory_SelectedIndexChanged(object sender, EventArgs e)
        {
            fact = (ItemAbstractFactory)factory.SelectedItem;
            ui = new UserInterface();
            ui.Flow = uiflow;
            ui.Hor = hor;
            fact.ConfigureInput(ui);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item i = fact.Create(ui);
            string[] row1 = { i.Type.Name, i.Description, i.Cost.ToString() };
            listView1.Items.Add(i.Horse.Name).SubItems.AddRange(row1);
            l.Add(i);
            //dataGridView1.Update();

            object[] buffer = new object[5];
            DataGridViewRow row = new DataGridViewRow();
                buffer[0] = i.Horse;
                buffer[1] = i.Type;
                buffer[2] = i.Description;
                buffer[3] = i.Date;
                buffer[4] = i.Cost;
                row.CreateCells(dataGridView1, buffer);
                dataGridView1.Rows.Add(row);

        }
    }
}
