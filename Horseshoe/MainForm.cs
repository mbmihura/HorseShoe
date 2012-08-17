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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Setup data binding
            factory.DataSource = Program.ItemCategories.getAllFactories();
            factory.DisplayMember = "Name";
            factory.ValueMember = null;

            List<Horse> caballos = new List<Horse>();
            caballos.Add(new Horse() { Name = "La Pituca" });
            caballos.Add(new Horse() { Name = "Millero" });
            hor.DataSource = caballos;
            hor.DisplayMember = "Name";
            hor.ValueMember = null;
        }
        ItemAbstractFactory fact;
        UserInterface ui;
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

        }
    }
}
