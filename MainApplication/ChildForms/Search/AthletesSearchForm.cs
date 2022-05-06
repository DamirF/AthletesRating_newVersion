using AthletesRating.GeneralFunctionality;
using AthletesRating.Models;
using MainApplication.GeneralFunctionality;
using MainApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainApplication.ChildForms.Search
{
    public partial class AthletesSearchForm : Form
    {
        private List<AthleteCard> cards;
        private Control[] searchControls;
        public AthletesSearchForm()
        {
            InitializeComponent();

            searchControls = new Control[3] { fullNameTB, sportTypeCB, nationalityCB};
            Functionality.ComboBoxStuff(ref sportTypeCB, ref Constants.SportTypes);
            Functionality.ComboBoxStuff(ref nationalityCB, ref Constants.Countries);
            sportTypeCB.SelectedIndex = 0;
            nationalityCB.SelectedIndex = 0;
            sportTypeCB.Text = sportTypeCB.Items[0].ToString();
            nationalityCB.Text = nationalityCB.Items[0].ToString();
            cards = AthleteSearchFunctionality.FindAll();
            Card.FillContent(ref Content, ref cards);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Content.Controls.Clear();
            cards = AthleteSearchFunctionality.SewrchWithParameters(ref searchControls);
            Card.FillContent(ref Content, ref cards);
        }
    }
}
