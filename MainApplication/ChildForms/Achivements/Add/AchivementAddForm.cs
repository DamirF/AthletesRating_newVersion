﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainApplication.ChildForms.Achivements.Add
{
    public partial class AchivementAddForm : Form
    {
        public AchivementAddForm()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}