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
using TrainManagementSystemGUI.UI;

namespace TrainManagementSystemGUI
{
    public partial class MainForm : Form
    {
        string path = "user.txt";
        public MainForm()
        {
            InitializeComponent();
            MUserDL.readDataFromFile(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void signUpClickButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            if (signUpForm.ShowDialog() == DialogResult.OK)
            {
                MUser user = signUpForm.GetUser();
                if (user != null)
                {
                    MUserDL.SignUp(user, path);
                    MessageBox.Show("Sign Up Successful!!");
                }
                else
                {
                    MessageBox.Show("!! You can't add User with this username or credentials because of already presence of this user!!||");
                }
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            DialogResult result = signInForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                string username = signInForm.GetUserName();
                string password = signInForm.GetPassword();
                MUser user = new MUser(username, password);
                string role = MUserDL.SignIn(user);
                if (role == null)
                {
                    MessageBox.Show("Invalid Username or password.");
                }
                else if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else if (role.Equals("Customer", StringComparison.OrdinalIgnoreCase))
                {
                    CustomerForm customerForm = new CustomerForm();
                    customerForm.Show();
                }
                else
                {
                    MessageBox.Show("Unknown role: " + role);
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Lavender;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.BlueViolet;
            label1.Text = "SUBWAY RESERVATION SYSTEM";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Tomato;
            label1.Text = "TRAIN MANAGEMENT SYSTEM";
        }

        private void signUpClickButton_MouseHover(object sender, EventArgs e)
        {
            signUpClickButton.BackColor = Color.BlueViolet;
        }

        private void signUpClickButton_MouseLeave(object sender, EventArgs e)
        {
            signUpClickButton.BackColor = Color.LightCoral;
        }

        private void signInButton_MouseHover(object sender, EventArgs e)
        {
            signInButton.BackColor = Color.BlueViolet;
        }

        private void signInButton_MouseLeave(object sender, EventArgs e)
        {
            signInButton.BackColor = Color.LightCoral;
        }

        private void ExitButton_MouseHover(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.BlueViolet;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.LightCoral;
        }
    }
}

