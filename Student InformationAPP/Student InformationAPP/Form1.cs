using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_InformationAPP
{
    public partial class StudentAPPUI : Form
    {
        public StudentAPPUI()
        {
            InitializeComponent();
        }

        private string reNo;
        private string firstName;
        private string lastName;

        private void showButton_Click(object sender, EventArgs e)
        {
            reNo = reNoTextBox.Text;
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;

            reNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;

            MessageBox.Show("firstName" + firstName + "   " + "lastName" + lastName + "   " + "your registation no is" +
                            reNo);
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {

            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            reNoTextBox.Text = reNo;

            MessageBox.Show("Message retrive successfully");
        }
    }
}
