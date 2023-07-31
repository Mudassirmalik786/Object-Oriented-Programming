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
    public partial class AddTrainForm : Form
    {
        string path = "train.txt";
        public AddTrainForm()
        {
            InitializeComponent();
            List<string> category = new List<string> { "Business", "Economy" };
            comboBoxTrainCategory.DataSource = category;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string trainName = textBoxTrainName.Text;
            string trainNumber = textBoxTrainNumber.Text;
            string trainOrigin = textBoxTrainOrigin.Text;
            string trainDestination = textBoxTrainDestination.Text;
            string trainCategory = comboBoxTrainCategory.Text;
            double trainFare = Convert.ToDouble(textBoxTrainFare.Text);
            string trainDeparture = textBoxTrainDeparture.Text;
            Train newTrain = new Train();
            newTrain.setTrainNumber(trainNumber);
            newTrain.setTrainName(trainName);
            newTrain.setOrigin(trainOrigin);
            newTrain.setDestination(trainDestination);
            newTrain.setCategory(trainCategory);
            newTrain.setFare(trainFare);
            newTrain.setDeparture(trainDeparture);
            if (string.IsNullOrEmpty(trainName) || string.IsNullOrEmpty(trainNumber) || string.IsNullOrEmpty(trainOrigin) || string.IsNullOrEmpty(trainDestination) || string.IsNullOrEmpty(trainCategory) || string.IsNullOrEmpty(Convert.ToString(trainFare)) || string.IsNullOrEmpty(trainDeparture))
            {
                MessageBox.Show("Please enter all the above fields");
                return;
            }
            TrainDL.StoreTrain(newTrain, path);
            MessageBox.Show("Train details saved successfully.");
            ClearInputFields();
            this.DialogResult = DialogResult.OK;
        }

        private void ClearInputFields()
        {
            textBoxTrainName.Text = "";
            textBoxTrainNumber.Text = "";
            textBoxTrainOrigin.Text = "";
            textBoxTrainDestination.Text = "";
            textBoxTrainFare.Text = "";
            textBoxTrainDeparture.Text = "";
        }

        private void textBoxTrainNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTrainName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                // Ignore numeric characters
                // Also ignoring special characters
            }
        }

        private void textBoxTrainOrigin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                // Ignore numeric characters
                // Also ignoring special characters
            }
        }

        private void comboBoxTrainCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                // Ignore numeric characters
                // Also ignoring special characters
                // Ignore non-numeric characters
            }
        }

        private void textBoxTrainFare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
              
                // Also ignoring special characters
                // Ignore non-numeric characters
            }
        }

        private void textBoxTrainDeparture_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTrainDestination_KeyPress(object sender, KeyPressEventArgs e)
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
