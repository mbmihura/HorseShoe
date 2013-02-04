using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Horseshoe.Models;
using Horseshoe.Models.Configuration;

namespace Horseshoe.Views.Controls
{
    public partial class ItemsInputView : UserControl
    {
        Control[] addControls;
        Control[] delControls;
        string type = "";

        public ItemsInputView()
        {
            InitializeComponent();
            addControls = new Control[6] { boxADinamicControlsContainer_flp, boxAHorse_cmb, boxAType_cmb, add_pic, boxASave_btn, boxACancel_btn };
            delControls = new Control[4] { boxDExplanation_lbl, boxDConfirm_btn, boxDCancel_lnk, delete_pic };
            foreach (DataGridViewColumn column in ItemList_dgv.Columns)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(column.HeaderText);
                menuItem.CheckOnClick = true;
                menuItem.Checked = column.Visible;
                menuItem.Tag = column.Name;
                menuItem.CheckedChanged += delegate(System.Object o, System.EventArgs e)
                                            {
                                                ItemList_dgv.Columns[menuItem.Tag.ToString()].Visible = menuItem.Checked;
                                            };
                dgvContextMenu.Items.Add(menuItem);
            }
        }

        ItemAbstractFactory fact;
        UserInterface ui;       
        private void boxAType_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fact = (ItemAbstractFactory)boxAType_cmb.SelectedItem;
            ui = new UserInterface();
            ui.Flow = boxADinamicControlsContainer_flp;
            ui.Hor = boxAHorse_cmb;
            fact.ConfigureInput(ui);
        }

        private void boxASave_btn_Click(object sender, EventArgs e)
        {
            Item i = fact.Create(ui);
        
            object[] buffer = new object[5];
            DataGridViewRow row = new DataGridViewRow();
            buffer[0] = i.Horse;
            buffer[1] = i.Type;
            buffer[2] = i.Description;
            buffer[3] = i.Date;
            buffer[4] = i.Cost;
            row.CreateCells(ItemList_dgv, buffer);
            ItemList_dgv.Rows.Add(row);
        }




        public object HorseDataSource
        {
            get { return boxAHorse_cmb.DataSource; }
            set { boxAHorse_cmb.DataSource = value; }
        }
        public object TypeDataSource
        {
            get { return boxAType_cmb.DataSource; }
            set { boxAType_cmb.DataSource = value; }
        }
               
        public void ShowMode(bool showDelete)
        {
            if (showDelete)
            {
                Array.ForEach(addControls, c => c.Hide()); //Hides adding controls
                add_lbl.ForeColor = Color.FromArgb(153, 153, 153);
                boxTitle_lbl.Text = "Eliminar " + type;
                delete_lbl.ForeColor = Color.FromArgb(102, 102, 102);
                Array.ForEach(delControls, c => c.Show()); //shows deletion controls
                //TODO: Mostrar columna eliminacion
            }
            else
            {
                //TODO: Ocultar columna eliminacion
                Array.ForEach(delControls, c => c.Hide()); //hides deletion controls
                delete_lbl.ForeColor = Color.FromArgb(153, 153, 153);
                boxTitle_lbl.Text = "Agregar " + type + ":";
                add_lbl.ForeColor = Color.FromArgb(102, 102, 102);
                Array.ForEach(addControls, c => c.Show()); //shows adding controls
            }
        }

        private void delete_lbl_Click(object sender, EventArgs e)
        {
            ShowMode(true);
        }

        private void add_lbl_Click(object sender, EventArgs e)
        {
            ShowMode(false);
        }

        private void boxDCancel_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowMode(false);
        }

        private void boxACancel_btn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvContextMenu.Show(ItemList_dgv, new Point(e.X, e.Y));
            }
        }

        private void boxDConfirm_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selection in ItemList_dgv.SelectedRows)
            {
                ItemList_dgv.Rows.Remove(selection);
            }
        }

      
    }
}
