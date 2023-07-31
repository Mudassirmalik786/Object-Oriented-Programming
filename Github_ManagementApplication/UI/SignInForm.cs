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

namespace TrainManagementSystemGUI.UI
{
    public partial class SignInForm : Form
    {
        private string usernname;
        private string password;
        public SignInForm()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            usernname = textBox1.Text.Trim();
            password = textBox2.Text.Trim();
            if(string.IsNullOrEmpty(usernname) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public string GetUserName()
        {
            return usernname;
        }
        public string GetPassword()
        {
            return password;
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signInButton_MouseHover(object sender, EventArgs e)
        {
            signInButton.BackColor = Color.PaleGreen;
        }

        private void signInButton_MouseLeave(object sender, EventArgs e)
        {
            signInButton.BackColor = Color.LawnGreen;
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
    }
}
