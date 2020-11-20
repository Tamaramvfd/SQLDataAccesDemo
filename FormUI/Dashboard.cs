using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();
            people= db.GetPeople(lastNameText.Text);

            UpdateBinding();
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();

            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailInstText.Text, phoneNumberInstText.Text);

            firstNameInsText.Text = "";
            lastNameInsText.Text = "";
            emailInstText.Text = "";
            phoneNumberInstText.Text = "";
        }
    }
}
