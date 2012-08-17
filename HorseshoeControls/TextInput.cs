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
    public partial class TextInput : UserControl
    {
        public TextInput()
        {
            InitializeComponent();
        }
        public TextInput(string defaultText):this()
        {
            input_txt.Text = defaultText;
        }
        public override string Text
        {
            get { return input_txt.Text; }
            set { input_txt.Text = value; }
        }
        public string Label
        {
            get { return title_lbl.Text; }
            set { title_lbl.Text = value; }
        }
    }
}
