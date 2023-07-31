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
    public partial class ViewFeedBackForm : Form
    {
        public ViewFeedBackForm()
        {
            InitializeComponent();
            ShowFeedBack();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowFeedBack()
        {
            listBox1.Items.Clear();
            string feedBack = AdminDL.readAnnouncement("feedBack.txt");
            listBox1.Items.Add(feedBack);
        }
    }
}
