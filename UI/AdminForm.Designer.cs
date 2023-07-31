
namespace TrainManagementSystemGUI.UI
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonViewUsers = new System.Windows.Forms.Button();
            this.AddTrainButton = new System.Windows.Forms.Button();
            this.buttonViewTrainSchedule = new System.Windows.Forms.Button();
            this.buttonUpdateTrain = new System.Windows.Forms.Button();
            this.buttonDeleteTrain = new System.Windows.Forms.Button();
            this.buttonViewFeedBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAnnouncement = new System.Windows.Forms.Button();
            this.buttonViewBookedTickets = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(958, 86);
            this.label1.TabIndex = 4;
            this.label1.Text = "TRAIN MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome Admin";
            // 
            // buttonViewUsers
            // 
            this.buttonViewUsers.AllowDrop = true;
            this.buttonViewUsers.AutoEllipsis = true;
            this.buttonViewUsers.BackColor = System.Drawing.Color.Lime;
            this.buttonViewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonViewUsers.Location = new System.Drawing.Point(2, 167);
            this.buttonViewUsers.Name = "buttonViewUsers";
            this.buttonViewUsers.Size = new System.Drawing.Size(273, 39);
            this.buttonViewUsers.TabIndex = 6;
            this.buttonViewUsers.Text = "View Users";
            this.buttonViewUsers.UseCompatibleTextRendering = true;
            this.buttonViewUsers.UseVisualStyleBackColor = false;
            this.buttonViewUsers.Click += new System.EventHandler(this.buttonViewUsers_Click);
            this.buttonViewUsers.MouseLeave += new System.EventHandler(this.buttonViewUsers_MouseLeave_1);
            this.buttonViewUsers.MouseHover += new System.EventHandler(this.buttonViewUsers_MouseHover_1);
            // 
            // AddTrainButton
            // 
            this.AddTrainButton.AllowDrop = true;
            this.AddTrainButton.AutoEllipsis = true;
            this.AddTrainButton.BackColor = System.Drawing.Color.Lime;
            this.AddTrainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddTrainButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTrainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddTrainButton.Location = new System.Drawing.Point(2, 200);
            this.AddTrainButton.Name = "AddTrainButton";
            this.AddTrainButton.Size = new System.Drawing.Size(273, 43);
            this.AddTrainButton.TabIndex = 7;
            this.AddTrainButton.Text = "Add a New Train";
            this.AddTrainButton.UseCompatibleTextRendering = true;
            this.AddTrainButton.UseVisualStyleBackColor = false;
            this.AddTrainButton.Click += new System.EventHandler(this.AddTrainButton_Click);
            this.AddTrainButton.MouseLeave += new System.EventHandler(this.AddTrainButton_MouseLeave);
            this.AddTrainButton.MouseHover += new System.EventHandler(this.AddTrainButton_MouseHover);
            // 
            // buttonViewTrainSchedule
            // 
            this.buttonViewTrainSchedule.AllowDrop = true;
            this.buttonViewTrainSchedule.AutoEllipsis = true;
            this.buttonViewTrainSchedule.BackColor = System.Drawing.Color.Lime;
            this.buttonViewTrainSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewTrainSchedule.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewTrainSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonViewTrainSchedule.Location = new System.Drawing.Point(2, 239);
            this.buttonViewTrainSchedule.Name = "buttonViewTrainSchedule";
            this.buttonViewTrainSchedule.Size = new System.Drawing.Size(273, 50);
            this.buttonViewTrainSchedule.TabIndex = 8;
            this.buttonViewTrainSchedule.Text = "View Train Schedule";
            this.buttonViewTrainSchedule.UseVisualStyleBackColor = false;
            this.buttonViewTrainSchedule.Click += new System.EventHandler(this.buttonViewTrainSchedule_Click);
            this.buttonViewTrainSchedule.MouseLeave += new System.EventHandler(this.buttonViewTrainSchedule_MouseLeave);
            this.buttonViewTrainSchedule.MouseHover += new System.EventHandler(this.buttonViewTrainSchedule_MouseHover);
            // 
            // buttonUpdateTrain
            // 
            this.buttonUpdateTrain.AllowDrop = true;
            this.buttonUpdateTrain.AutoEllipsis = true;
            this.buttonUpdateTrain.BackColor = System.Drawing.Color.Lime;
            this.buttonUpdateTrain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateTrain.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateTrain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonUpdateTrain.Location = new System.Drawing.Point(2, 285);
            this.buttonUpdateTrain.Name = "buttonUpdateTrain";
            this.buttonUpdateTrain.Size = new System.Drawing.Size(273, 50);
            this.buttonUpdateTrain.TabIndex = 9;
            this.buttonUpdateTrain.Text = "Update An Existing Train";
            this.buttonUpdateTrain.UseVisualStyleBackColor = false;
            this.buttonUpdateTrain.Click += new System.EventHandler(this.buttonUpdateTrain_Click);
            this.buttonUpdateTrain.MouseLeave += new System.EventHandler(this.buttonUpdateTrain_MouseLeave);
            this.buttonUpdateTrain.MouseHover += new System.EventHandler(this.buttonUpdateTrain_MouseHover);
            // 
            // buttonDeleteTrain
            // 
            this.buttonDeleteTrain.AllowDrop = true;
            this.buttonDeleteTrain.AutoEllipsis = true;
            this.buttonDeleteTrain.BackColor = System.Drawing.Color.Lime;
            this.buttonDeleteTrain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteTrain.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTrain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonDeleteTrain.Location = new System.Drawing.Point(2, 325);
            this.buttonDeleteTrain.Name = "buttonDeleteTrain";
            this.buttonDeleteTrain.Size = new System.Drawing.Size(273, 44);
            this.buttonDeleteTrain.TabIndex = 10;
            this.buttonDeleteTrain.Text = "Delete An Existing Train";
            this.buttonDeleteTrain.UseVisualStyleBackColor = false;
            this.buttonDeleteTrain.Click += new System.EventHandler(this.buttonDeleteTrain_Click);
            this.buttonDeleteTrain.MouseLeave += new System.EventHandler(this.buttonDeleteTrain_MouseLeave);
            this.buttonDeleteTrain.MouseHover += new System.EventHandler(this.buttonDeleteTrain_MouseHover);
            // 
            // buttonViewFeedBack
            // 
            this.buttonViewFeedBack.AllowDrop = true;
            this.buttonViewFeedBack.AutoEllipsis = true;
            this.buttonViewFeedBack.BackColor = System.Drawing.Color.Lime;
            this.buttonViewFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewFeedBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewFeedBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonViewFeedBack.Location = new System.Drawing.Point(2, 361);
            this.buttonViewFeedBack.Name = "buttonViewFeedBack";
            this.buttonViewFeedBack.Size = new System.Drawing.Size(274, 44);
            this.buttonViewFeedBack.TabIndex = 11;
            this.buttonViewFeedBack.Text = "View FeedBack";
            this.buttonViewFeedBack.UseVisualStyleBackColor = false;
            this.buttonViewFeedBack.Click += new System.EventHandler(this.buttonViewFeedBack_Click);
            this.buttonViewFeedBack.MouseLeave += new System.EventHandler(this.buttonViewFeedBack_MouseLeave);
            this.buttonViewFeedBack.MouseHover += new System.EventHandler(this.buttonViewFeedBack_MouseHover);
            // 
            // buttonExit
            // 
            this.buttonExit.AllowDrop = true;
            this.buttonExit.AutoEllipsis = true;
            this.buttonExit.BackColor = System.Drawing.Color.Lime;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.DarkCyan;
            this.buttonExit.Location = new System.Drawing.Point(2, 507);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(274, 42);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseCompatibleTextRendering = true;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            this.buttonExit.MouseHover += new System.EventHandler(this.buttonExit_MouseHover);
            // 
            // buttonAnnouncement
            // 
            this.buttonAnnouncement.AllowDrop = true;
            this.buttonAnnouncement.AutoEllipsis = true;
            this.buttonAnnouncement.BackColor = System.Drawing.Color.Lime;
            this.buttonAnnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnnouncement.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnouncement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAnnouncement.Location = new System.Drawing.Point(2, 400);
            this.buttonAnnouncement.Name = "buttonAnnouncement";
            this.buttonAnnouncement.Size = new System.Drawing.Size(274, 64);
            this.buttonAnnouncement.TabIndex = 13;
            this.buttonAnnouncement.Text = "Announcement for Customers";
            this.buttonAnnouncement.UseCompatibleTextRendering = true;
            this.buttonAnnouncement.UseVisualStyleBackColor = false;
            this.buttonAnnouncement.Click += new System.EventHandler(this.buttonAnnouncement_Click);
            this.buttonAnnouncement.MouseLeave += new System.EventHandler(this.buttonAnnouncement_MouseLeave);
            this.buttonAnnouncement.MouseHover += new System.EventHandler(this.buttonAnnouncement_MouseHover);
            // 
            // buttonViewBookedTickets
            // 
            this.buttonViewBookedTickets.AllowDrop = true;
            this.buttonViewBookedTickets.AutoEllipsis = true;
            this.buttonViewBookedTickets.BackColor = System.Drawing.Color.Lime;
            this.buttonViewBookedTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewBookedTickets.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewBookedTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonViewBookedTickets.Location = new System.Drawing.Point(2, 461);
            this.buttonViewBookedTickets.Name = "buttonViewBookedTickets";
            this.buttonViewBookedTickets.Size = new System.Drawing.Size(274, 51);
            this.buttonViewBookedTickets.TabIndex = 14;
            this.buttonViewBookedTickets.Text = "View Booked Tickets";
            this.buttonViewBookedTickets.UseCompatibleTextRendering = true;
            this.buttonViewBookedTickets.UseVisualStyleBackColor = false;
            this.buttonViewBookedTickets.Click += new System.EventHandler(this.buttonViewBookedTickets_Click);
            this.buttonViewBookedTickets.MouseLeave += new System.EventHandler(this.buttonViewBookedTickets_MouseLeave);
            this.buttonViewBookedTickets.MouseHover += new System.EventHandler(this.buttonViewBookedTickets_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(274, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1096, 758);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Lime;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 749);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.buttonViewBookedTickets);
            this.Controls.Add(this.buttonAnnouncement);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonViewFeedBack);
            this.Controls.Add(this.buttonDeleteTrain);
            this.Controls.Add(this.buttonUpdateTrain);
            this.Controls.Add(this.buttonViewTrainSchedule);
            this.Controls.Add(this.AddTrainButton);
            this.Controls.Add(this.buttonViewUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonViewUsers;
        private System.Windows.Forms.Button AddTrainButton;
        private System.Windows.Forms.Button buttonViewTrainSchedule;
        private System.Windows.Forms.Button buttonUpdateTrain;
        private System.Windows.Forms.Button buttonDeleteTrain;
        private System.Windows.Forms.Button buttonViewFeedBack;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAnnouncement;
        private System.Windows.Forms.Button buttonViewBookedTickets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}