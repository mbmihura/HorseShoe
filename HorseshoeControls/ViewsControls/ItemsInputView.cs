using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HorseshoeControls.ViewsControls
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
    }
}
