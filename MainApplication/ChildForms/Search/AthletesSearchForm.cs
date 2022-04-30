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
        public AthletesSearchForm()
        {
            InitializeComponent();
            cards = AthleteSearchFunctionality.FindAll();
            Card.FillContent(ref Content, ref cards);
        }
    }
}
