using AthletesRating.GeneralFunctionality;
using System.Data;
using System.Data.SqlClient;
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

        private void FillTable()
        {
            if(Functionality.connection.State != ConnectionState.Open) Functionality.connection.Open();
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            SqlDataAdapter readFromAccounts = new SqlDataAdapter("SELECT Email, Login, IsAdmin FROM Accounts", Functionality.connection);
            SqlDataAdapter readFromAthletes = new SqlDataAdapter("SELECT Surname, Name, Patronymic, Gender, BirthDate, Nationality, SportType, Login FROM Athletes", Functionality.connection);
            readFromAccounts.Fill(ds1);
            readFromAthletes.Fill(ds2);
            dataGridAccounts.DataSource = ds1.Tables[0];
            dataGridAthletes.DataSource = ds2.Tables[0];

            dataGridAccounts.ReadOnly = true;
            dataGridAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridAthletes.ReadOnly = true;
            dataGridAthletes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
