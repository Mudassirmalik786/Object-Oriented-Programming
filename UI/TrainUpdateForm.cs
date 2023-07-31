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
    public partial class TrainUpdateForm : Form
    {
        private static List<Train> TrainList = TrainDL.getList();
        public TrainUpdateForm()
        {
            InitializeComponent();
            TrainDL.readTrainFromFile("train.txt");
            List<string> category = new List<string> { "Business", "Economy" };
            comboBoxTrainCategory.DataSource = category;
        }
        private Train CheckTrain(string trainNumber)
        {
            Train TrainToUpdate = TrainList.Find(t => t.getTrainNumber() == trainNumber);
            return TrainToUpdate;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string trainNumber = textBoxTrainNumber.Text;
            Train trainToUpdate = CheckTrain(trainNumber);
            if (trainToUpdate != null)
            {
                string trainName = textBoxTrainName.Text;
                string trainOrigin = textBoxOrigin.Text;
                string trainDestination = textBoxDestination.Text;
                string category = comboBoxTrainCategory.Text;
                double trainFare = Convert.ToDouble(textBoxFare.Text);
                string trainDeparture = textBoxDeparture.Text;
                trainToUpdate.setTrainNumber(trainNumber);
                trainToUpdate.setTrainName(trainName);
                trainToUpdate.setOrigin(trainOrigin);
                trainToUpdate.setDestination(trainDestination);
                trainToUpdate.setCategory(category);
                trainToUpdate.setFare(trainFare);
                trainToUpdate.setDeparture(trainDeparture);

                TrainDL.StoreTrainListintoFile(TrainList, "train.txt");
                MessageBox.Show("The given has been Updated");
                ClearInputFields();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("The train is not present that's why Data has not been updated");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string trainNumber = textBoxTrainNumber.Text;
            Train TrainToUpdate = TrainList.Find(t => t.getTrainNumber() == trainNumber);
            if(TrainToUpdate != null)
            {
                MessageBox.Show("Train Present");
            }
            else
            {
                MessageBox.Show("Train Not Present");
            }
        }
        private void ClearInputFields()
        {
            textBoxTrainName.Text = "";
            textBoxTrainNumber.Text = "";
            textBoxOrigin.Text = "";
            textBoxDestination.Text = "";
            comboBoxTrainCategory.Text = "";
            textBoxFare.Text = "";
            textBoxDeparture.Text = "";
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

        private void textBoxOrigin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                // Ignore numeric characters
                // Also ignoring special characters
            }
        }

        private void textBoxDestination_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxFare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;

                // Also ignoring special characters
                // Ignore non-numeric characters
            }
        }

        private void textBoxDeparture_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
