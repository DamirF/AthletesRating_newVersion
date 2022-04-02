﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MainApplication.GeneralFunctionality
{
    internal class ChildForm
    {
        private static Form activeForm = null;
        public static void openChildForm(Form childForm, Panel panelChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}
