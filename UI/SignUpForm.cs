using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainManagementSystemGUI.BL;
using TrainManagementSystemGUI.DL;

namespace TrainManagementSystemGUI.UI
{
    public partial class SignUpForm : Form
    {
        private MUser user;
        public SignUpForm()
        {
            InitializeComponent();
            List<string> roleTaking = new List<string>() { "Drag To Select" , "Admin", "Customer" };
            comboBox1.DataSource = roleTaking;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string role = comboBox1.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please enter all the required fields.");
                return;
            }
            user = new MUser(username, password, role);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public MUser GetUser()
        {
            bool found = MUserDL.TakeInputwithRole(user);
            if (found == true)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                // Ignore numeric characters
                // Also ignoring special characters
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                // Ignore numeric characters
                // Also ignoring special characters
                // Ignore non-numeric characters
            }
        }
    }
}
