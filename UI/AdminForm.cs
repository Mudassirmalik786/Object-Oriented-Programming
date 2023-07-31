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
    public partial class AdminForm : Form
    {
        public static List<MUser> usersList = MUserDL.getList();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void buttonViewUsers_Click(object sender, EventArgs e)
        {
            ViewUsersForm viewUsersForm = new ViewUsersForm();
            viewUsersForm.ShowDialog();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void AddTrainButton_Click(object sender, EventArgs e)
        {
            AddTrainForm addTrainForm = new AddTrainForm();
            addTrainForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonViewTrainSchedule_Click(object sender, EventArgs e)
        {
            TrainScheduleForm trainScheduleForm = new TrainScheduleForm();
            trainScheduleForm.ShowDialog();
        }

        private void buttonUpdateTrain_Click(object sender, EventArgs e)
        {
            TrainUpdateForm trainUpdateForm = new TrainUpdateForm();
            trainUpdateForm.ShowDialog();
        }

        private void buttonDeleteTrain_Click(object sender, EventArgs e)
        {
            DeleteTrainForm deleteTrainForm = new DeleteTrainForm();
            deleteTrainForm.ShowDialog();
        }

        private void buttonAnnouncement_Click(object sender, EventArgs e)
        {
            AnnouncementForm announcementForm = new AnnouncementForm();
            announcementForm.ShowDialog();
        }

        private void buttonViewFeedBack_Click(object sender, EventArgs e)
        {
            ViewFeedBackForm viewFeedBackForm = new ViewFeedBackForm();
            viewFeedBackForm.ShowDialog();
        }

        private void buttonViewBookedTickets_Click(object sender, EventArgs e)
        {
            BookedTicketsForm bookedTicketsForm = new BookedTicketsForm();
            bookedTicketsForm.ShowDialog();
        }

        private void buttonViewUsers_MouseHover_1(object sender, EventArgs e)
        {
            buttonViewUsers.BackColor = Color.DeepSkyBlue;
            buttonViewUsers.Anchor = AnchorStyles.Top;
            buttonViewUsers.ForeColor = Color.Aquamarine;
        }

        private void buttonViewUsers_MouseLeave_1(object sender, EventArgs e)
        {
            buttonViewUsers.BackColor = Color.Lime;
            buttonViewUsers.ForeColor = Color.SaddleBrown;
        }

        private void AddTrainButton_MouseHover(object sender, EventArgs e)
        {
            AddTrainButton.BackColor = Color.DeepSkyBlue;
            AddTrainButton.Anchor = AnchorStyles.Top;
            AddTrainButton.ForeColor = Color.Aquamarine;
        }

        private void AddTrainButton_MouseLeave(object sender, EventArgs e)
        {
            AddTrainButton.BackColor = Color.Lime;
            AddTrainButton.ForeColor = Color.SaddleBrown;
        }

        private void buttonViewTrainSchedule_MouseHover(object sender, EventArgs e)
        {
            buttonViewTrainSchedule.BackColor = Color.DeepSkyBlue;
            buttonViewTrainSchedule.Anchor = AnchorStyles.Top;
            buttonViewTrainSchedule.ForeColor = Color.Aquamarine;
        }

        private void buttonViewTrainSchedule_MouseLeave(object sender, EventArgs e)
        {
            buttonViewTrainSchedule.BackColor = Color.Lime;
            buttonViewTrainSchedule.ForeColor = Color.SaddleBrown;
        }

        private void buttonUpdateTrain_MouseHover(object sender, EventArgs e)
        {
            buttonUpdateTrain.BackColor = Color.DeepSkyBlue;
            buttonUpdateTrain.Anchor = AnchorStyles.Top;
            buttonUpdateTrain.ForeColor = Color.Aquamarine;
        }

        private void buttonUpdateTrain_MouseLeave(object sender, EventArgs e)
        {
           buttonUpdateTrain.BackColor = Color.Lime;
            buttonUpdateTrain.ForeColor = Color.SaddleBrown;
        }

        private void buttonDeleteTrain_MouseHover(object sender, EventArgs e)
        {
            buttonDeleteTrain.BackColor = Color.DeepSkyBlue;
            buttonDeleteTrain.Anchor = AnchorStyles.Top;
            buttonDeleteTrain.ForeColor = Color.Aquamarine;
        }

        private void buttonDeleteTrain_MouseLeave(object sender, EventArgs e)
        {
            buttonDeleteTrain.BackColor = Color.Lime;
            buttonDeleteTrain.ForeColor = Color.SaddleBrown;
        }

        private void buttonViewFeedBack_MouseHover(object sender, EventArgs e)
        {
            buttonViewFeedBack.BackColor = Color.DeepSkyBlue;
            buttonViewFeedBack.Anchor = AnchorStyles.Top;
            buttonViewFeedBack.ForeColor = Color.Aquamarine;
        }

        private void buttonViewFeedBack_MouseLeave(object sender, EventArgs e)
        {
            buttonViewFeedBack.BackColor = Color.Lime;
            buttonViewFeedBack.ForeColor = Color.SaddleBrown;
        }

        private void buttonAnnouncement_MouseHover(object sender, EventArgs e)
        {
            buttonAnnouncement.BackColor = Color.DeepSkyBlue;
            buttonAnnouncement.Anchor = AnchorStyles.Top;
            buttonAnnouncement.ForeColor = Color.Aquamarine;
        }

        private void buttonAnnouncement_MouseLeave(object sender, EventArgs e)
        {
            buttonAnnouncement.BackColor = Color.Lime;
            buttonAnnouncement.ForeColor = Color.SaddleBrown;
        }

        private void buttonViewBookedTickets_MouseHover(object sender, EventArgs e)
        {
            buttonViewBookedTickets.BackColor = Color.DeepSkyBlue;
            buttonViewBookedTickets.Anchor = AnchorStyles.Top;
            buttonViewBookedTickets.ForeColor = Color.Aquamarine;
        }

        private void buttonViewBookedTickets_MouseLeave(object sender, EventArgs e)
        {
            buttonViewBookedTickets.BackColor = Color.Lime;
            buttonViewBookedTickets.ForeColor = Color.SaddleBrown;
        }

        private void buttonExit_MouseHover(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.DeepSkyBlue;
            buttonExit.Anchor = AnchorStyles.Top;
            buttonExit.ForeColor = Color.Aquamarine;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Lime;
            buttonExit.ForeColor = Color.SaddleBrown;
        }
    }
}
