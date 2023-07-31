
namespace GameGUI
{
    partial class Level2
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
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.ghostTimer = new System.Windows.Forms.Timer(this.components);
            this.bulletLoop = new System.Windows.Forms.Timer(this.components);
            this.ghost1timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Salmon;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(119, 495);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(79, 32);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "label1";
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.BackColor = System.Drawing.Color.Aquamarine;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.Location = new System.Drawing.Point(900, 495);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(129, 25);
            this.lblPlayerHealth.TabIndex = 3;
            this.lblPlayerHealth.Text = "Player Health";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.YellowGreen;
            this.progressBar1.Location = new System.Drawing.Point(1037, 495);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 25);
            this.progressBar1.Step = 3;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 100;
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 50;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // ghostTimer
            // 
            this.ghostTimer.Enabled = true;
            this.ghostTimer.Interval = 800;
            this.ghostTimer.Tick += new System.EventHandler(this.ghostTimer_Tick);
            // 
            // bulletLoop
            // 
            this.bulletLoop.Enabled = true;
            this.bulletLoop.Interval = 80;
            this.bulletLoop.Tick += new System.EventHandler(this.bulletLoop_Tick);
            // 
            // ghost1timer
            // 
            this.ghost1timer.Interval = 800;
            this.ghost1timer.Tick += new System.EventHandler(this.ghost1timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "LEVEL 2";
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameGUI.Properties.Resources.simplebox;
            this.ClientSize = new System.Drawing.Size(1249, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.lblScore);
            this.DoubleBuffered = true;
            this.Name = "Level2";
            this.Text = "Level2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Level2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Timer ghostTimer;
        private System.Windows.Forms.Timer bulletLoop;
        private System.Windows.Forms.Timer ghost1timer;
        private System.Windows.Forms.Label label1;
    }
}