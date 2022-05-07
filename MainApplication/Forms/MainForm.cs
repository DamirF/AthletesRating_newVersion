using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AthletesRating.GeneralFunctionality;
using MainApplication.ChildForms.Profile;
using MainApplication.ChildForms.Search;
using MainApplication.ChildForms.Settings;
using MainApplication.GeneralFunctionality;
using MainApplication.ChildForms.Admin.View;
using SportsmansRating;
using MainApplication.ChildForms.Admin.Edit;
using MainApplication.ChildForms.HomePage;

namespace MainApplication.Forms
{
    public partial class MainForm : Form
    {
        AthleteCard athlete;
        Panel[] submenu;
        Button[] menuBtns;
        public MainForm()
        {
            InitializeComponent();
            athlete = AuthorizationForm.GetAthlete();
            submenu = new Panel[] { submenuAccountsAdministration};
            menuBtns = new Button[] { menuAccountsAdministration };
            Submenu.customizeDesign(ref menuBtns, submenu);
            athlete = Functionality.GetAtheleteInfo(athlete);
            if (Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();

            if (!athlete.accountInfo.isAdmin) menuAccountsAdministration.Visible = false;

            if (athlete == null)
            {
                AuthorizationForm authorization = new AuthorizationForm();
                authorization.Show();
                MessageBox.Show("Не удалось найти информацию пользователя.\nАккаунт удален.\nПожалуйста, пройдите повторную регистрацию.");
                Close();
                return;
            }
        }

        public MainForm(string withoutAccountMode)
        {
            InitializeComponent();
            submenu = new Panel[] { submenuAccountsAdministration };
            menuBtns = new Button[] { menuAccountsAdministration };
            Submenu.customizeDesign(ref menuBtns, submenu);
            if (Functionality.connection.State == ConnectionState.Closed) Functionality.connection.Open();
            menuProfile.Visible = false;
            menuSettings.Visible = false;
            menuAccountsAdministration.Visible = false;
        }

        private void menuProfile_Click(object sender, EventArgs e)
        {
            Submenu.hideSubmenu(ref menuBtns, submenu);
            ChildForm.Open(new ProfileForm(athlete), panelChildForm);
        }

        private void nemuSettings_Click(object sender, EventArgs e)
        {
            Submenu.hideSubmenu(ref menuBtns, submenu);
            ChildForm.Open(new AccountSettingsForm(athlete), panelChildForm);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Submenu.hideSubmenu(ref menuBtns, submenu);
            ChildForm.Open(new AthletesSearchForm(), panelChildForm);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Functionality.AccountExit(this);
        }

        private void menuAccountsAdministration_Click(object sender, EventArgs e)
        {
            Submenu.showSubmenu((Button)sender, ref menuBtns, submenuAccountsAdministration, submenu);
        }

        private void AccountsAdministrationView_Click(object sender, EventArgs e)
        {
            Submenu.hideSubmenu(ref menuBtns, submenu);
            ChildForm.Open(new AccountsViewForm(), panelChildForm);
        }

        private void AccountsAdministrationEdit_Click(object sender, EventArgs e)
        {
            Submenu.hideSubmenu(ref menuBtns, submenu);
            ChildForm.Open(new AccountsEditForm(athlete), panelChildForm);
        }

        private void menuProfile_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font, FontStyle.Underline);
        }

        private void menuProfile_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font, FontStyle.Bold);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChildForm.Open(new HomePage(), panelChildForm);
        }

        private void HomePageBtn_Click(object sender, EventArgs e)
        {
            ChildForm.Open(new HomePage(), panelChildForm);
        }
    }
}
