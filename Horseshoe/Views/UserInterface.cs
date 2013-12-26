using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Horseshoe.Models;
using System.Windows.Forms;

namespace Horseshoe
{
    class UserInterface
    {
        public ComboBox Hor { get; set; }
        public Horse Horse
        {
            get { return ((Horse)Hor.SelectedItem); }
        }
        public FlowLayoutPanel Flow { get; set; }


        internal void Clear()
        {
            Flow.Controls.Clear();
        }

        internal void Show(System.Windows.Forms.UserControl control)
        {
            Flow.Controls.Add(control);
            Flow.Update();
        }
    }
}
