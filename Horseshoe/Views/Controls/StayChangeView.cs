using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Horseshoe.Views.Controls
{
    public partial class StayChangeView : UserControl
    {
        Control[] addControls;
        Control[] delControls;

        public StayChangeView()
        {
            InitializeComponent();
            addControls = new Control[8] { boxAHorse_cmb, boxAType_cmb, dateInput, add_pic, boxASave_btn, boxACancel_btn, boxAHorses_lbl, boxAType_lbl };
            delControls = new Control[3] { boxDExplanation_lbl, boxDConfirm_btn, delete_pic };
            ShowMode(false);
            boxAHorse_cmb.Focus();
        }
        public void Show()
        {
            base.Show();
            boxAHorse_cmb.Focus();
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
                boxTitle_lbl.Text = "Eliminar Estadia";
                delete_lbl.ForeColor = Color.FromArgb(102, 102, 102);
                Array.ForEach(delControls, c => c.Show()); //shows deletion controls
                boxLeftTriangle_pic.Top -= 75;
                box_pnl.Height -= 75;
                stayList_dgv.Top -= 75;
                stayList_dgv.Height += 75;
                //TODO: Mostrar columna eliminacion
            }
            else
            {
                //TODO: Ocultar columna eliminacion
                Array.ForEach(delControls, c => c.Hide()); //hides deletion controls
                delete_lbl.ForeColor = Color.FromArgb(153, 153, 153);
                boxTitle_lbl.Text = "Agregar Estadia:";
                add_lbl.ForeColor = Color.FromArgb(102, 102, 102);
                Array.ForEach(addControls, c => c.Show()); //shows adding controls
                box_pnl.Height = 210;
                boxLeftTriangle_pic.Top = 267;
                stayList_dgv.Top = 279;
                stayList_dgv.Height -= 75;

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

        private void box_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
