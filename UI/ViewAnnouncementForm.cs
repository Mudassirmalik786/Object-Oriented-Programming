using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainManagementSystemGUI.DL;

namespace TrainManagementSystemGUI.UI
{
    public partial class ViewAnnouncementForm : Form
    {
        public ViewAnnouncementForm()
        {
            InitializeComponent();
            ShowAnnouncement();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowAnnouncement()
        {
            listBox1.Items.Clear();
            string announcement = AdminDL.readAnnouncement("announcement.txt");
            listBox1.Items.Add(announcement);
        }
    }
}
