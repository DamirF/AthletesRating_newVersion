using AthletesRating.GeneralFunctionality;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainApplication.ChildForms.Admin.View
{
    public partial class AccountsViewForm : Form
    {
        public AccountsViewForm()
        {
            InitializeComponent();
            FillTable();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillTable()
        {
            if(Functionality.connection.State != ConnectionState.Open) Functionality.connection.Open();
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            SqlDataAdapter readFromAccounts = new SqlDataAdapter("SELECT Id, Email, Login, IsAdmin FROM Accounts", Functionality.connection);
            SqlDataAdapter readFromAthletes = new SqlDataAdapter("SELECT Id, Surname, Name, Patronymic, BirthDate, Gender FROM Athletes", Functionality.connection);
            readFromAccounts.Fill(ds1);
            readFromAthletes.Fill(ds2);
            UsersAccountData.DataSource = ds1.Tables[0];
            UsersPersonalData.DataSource = ds2.Tables[0];

            UsersAccountData.ReadOnly = true;
            UsersAccountData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            UsersPersonalData.ReadOnly = true;
            UsersPersonalData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
