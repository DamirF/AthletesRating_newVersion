using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainApplication.Forms
{
    public partial class StuffScr : Form
    {
        public StuffScr()
        {
            InitializeComponent();
        }

        private void Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsNumber(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }
    }
}
