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
    public partial class DropListInput : UserControl
    {
        public DropListInput()
        {
            InitializeComponent();
        }
        // TODO: Define method to manage combobox control.
        public string Label
        {
            get { return title_lbl.Text; }
            set { title_lbl.Text = value; }
        }
    }
}
