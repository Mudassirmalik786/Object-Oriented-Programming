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
    public partial class DeleteTrainForm : Form
    {
        public DeleteTrainForm()
        {
            InitializeComponent();
            TrainDL.readTrainFromFile("train.txt");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTrainDelete_Click(object sender, EventArgs e)
        {
            string trainNumber = textBoxTrainNumber.Text;
            string trainName = textBoxTrainName.Text;
            if(string.IsNullOrEmpty(trainNumber) || string.IsNullOrEmpty(trainName))
            {
                MessageBox.Show("You have missed some field unfilled!!");
                return;
            }
            Train train = null;
            Train trainToDelete = TrainDL.checkPresenceofTrain(train, trainNumber, trainName);
            if (trainToDelete != null)
            {
                TrainDL.deleteTrainFromList(trainToDelete, "train.txt");
                MessageBox.Show("Train has been Deleted");
                ClearInputFields();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Train with the specified number and name doesn't exist");
                ClearInputFields();
            }
        }
        private void ClearInputFields()
        {
            textBoxTrainNumber.Text = "";
            textBoxTrainName.Text = "";
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

        private void textBoxTrainName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
