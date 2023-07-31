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
    public partial class TrainScheduleForm : Form
    {
        List<Train> trains;
        public TrainScheduleForm()
        {
            InitializeComponent();
            trains = TrainDL.getList();
            trains.Clear();
            TrainDL.readTrainFromFile("train.txt");
            dataGridView1.DataSource = trains;
            dataGridView1.Refresh();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
