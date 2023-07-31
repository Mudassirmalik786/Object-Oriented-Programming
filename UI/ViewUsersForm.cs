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
    public partial class ViewUsersForm : Form
    {
        List<MUser> usersList;

        public ViewUsersForm()
        {
            InitializeComponent();
            usersList = MUserDL.getList();
            usersList.Clear();
            MUserDL.readDataFromFile("user.txt");
            dataGridViewUsers.DataSource = usersList;
            dataGridViewUsers.Refresh();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewUsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }

}
