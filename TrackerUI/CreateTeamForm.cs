using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            // Create a person Model out of the four fields
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = surnameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellNumber = cellValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

            }

            else
            {
                MessageBox.Show("Please fill in all the fields");
            }
        }

        //valdate form
        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (surnameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (cellValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
