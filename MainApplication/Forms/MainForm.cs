using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AthletesRating.GeneralFunctionality;
using MainApplication.ChildForms.Achivements.Add;
using MainApplication.ChildForms.Achivements.View;
using MainApplication.ChildForms.Profile;
using MainApplication.ChildForms.Search;
using MainApplication.ChildForms.Settings;
using MainApplication.GeneralFunctionality;
using SportsmansRating;

namespace MainApplication.Forms
{
    public partial class MainForm : Form
    {
        AthleteCard athlete;
        Panel[] submenu;
        public MainForm()
        {
            InitializeComponent();
            athlete = AuthorizationForm.GetAthlete();
            submenu = new Panel[] { panelAchivementsSubmenu};
            Submenu.customizeDesign(submenu);
            athlete = Functionality.GetAtheleteInfo(athlete);
            if (Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();

            if (athlete == null)
            {
                AuthorizationForm authorization = new AuthorizationForm();
                authorization.Show();
                MessageBox.Show("Не удалось найти информацию пользователя.\nАккаунт удален.\nПожалуйста, пройдите повторную регистрацию.");
                Close();
                return;
            }
        }

        private void menuAchivements_Click(object sender, EventArgs e)
        {
            Submenu.showSubmenu(panelAchivementsSubmenu, submenu);
        }

        private void menuProfile_Click(object sender, EventArgs e)
        {
            Submenu.hideSubmenu(submenu);
            ChildForm.openChildForm(new ProfileForm(athlete), panelChildForm);
        }

        private void nemuSettings_Click(object sender, EventArgs e)
        {
            Submenu.hideSubmenu(submenu);
            ChildForm.openChildForm(new AccountSettingsForm(athlete), panelChildForm);
        }

        private void submenuAchivementsView_Click(object sender, EventArgs e)
        {
            Submenu.hideSubmenu(submenu);
            ChildForm.openChildForm(new AchivementsViewForm(), panelChildForm);
        }

        private void submenuAchivementsAdd_Click(object sender, EventArgs e)
        {
            Submenu.hideSubmenu(submenu);
            ChildForm.openChildForm(new AchivementAddForm(), panelChildForm);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Submenu.hideSubmenu(submenu);
            ChildForm.openChildForm(new AthletesSearchForm(), panelChildForm);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Functionality.AccountExit(this);
        }
    }
}
