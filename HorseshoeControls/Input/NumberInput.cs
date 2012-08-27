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
    public partial class NumberInput : UserControl
    {
        public NumberInput()
        {
            InitializeComponent();
        }
        public NumberInput(decimal defaultValue) : this()
        {
            input_nud.Value = defaultValue;
        }
        public  decimal Value
        {
            get { return input_nud.Value; }
            set { input_nud.Value  = value; }
        }
        public int DecimalPlaces
        {
            get { return input_nud.DecimalPlaces;}
            set { input_nud.DecimalPlaces = value; }
        }
        public string Label
        {
            get { return title_lbl.Text; }
            set { title_lbl.Text = value; }
        }
    }
}
