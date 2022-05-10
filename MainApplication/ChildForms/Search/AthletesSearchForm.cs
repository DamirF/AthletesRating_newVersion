using AthletesRating.GeneralFunctionality;
using AthletesRating.Models;
using MainApplication.GeneralFunctionality;
using MainApplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
            cards = AthleteSearchFunctionality.SearchWithParameters(ref searchControls);
            Card.FillContent(ref Content, ref cards);
            if (cards.Count == 0) MessageBox.Show("Поиск не дал результатов!");
        }

        private void sportTypeCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void nationalityCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void AthletesSearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
