
namespace TrainManagementSystemGUI.UI
{
    partial class DeleteTrainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTrainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTrainNumber = new System.Windows.Forms.TextBox();
            this.textBoxTrainName = new System.Windows.Forms.TextBox();
            this.buttonTrainDelete = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "TRAIN MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Delete Train Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Train Number you want to Delete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Train Name you want to Delete";
            // 
            // textBoxTrainNumber
            // 
            this.textBoxTrainNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrainNumber.Location = new System.Drawing.Point(708, 356);
            this.textBoxTrainNumber.Name = "textBoxTrainNumber";
            this.textBoxTrainNumber.Size = new System.Drawing.Size(266, 29);
            this.textBoxTrainNumber.TabIndex = 10;
            this.textBoxTrainNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTrainNumber_KeyPress);
            // 
            // textBoxTrainName
            // 
            this.textBoxTrainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrainName.Location = new System.Drawing.Point(707, 436);
            this.textBoxTrainName.Name = "textBoxTrainName";
            this.textBoxTrainName.Size = new System.Drawing.Size(267, 29);
            this.textBoxTrainName.TabIndex = 11;
            this.textBoxTrainName.TextChanged += new System.EventHandler(this.textBoxTrainName_TextChanged);
            this.textBoxTrainName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTrainName_KeyPress);
            // 
            // buttonTrainDelete
            // 
            this.buttonTrainDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonTrainDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrainDelete.Location = new System.Drawing.Point(950, 546);
            this.buttonTrainDelete.Name = "buttonTrainDelete";
            this.buttonTrainDelete.Size = new System.Drawing.Size(98, 36);
            this.buttonTrainDelete.TabIndex = 12;
            this.buttonTrainDelete.Text = "Delete";
            this.buttonTrainDelete.UseVisualStyleBackColor = false;
            this.buttonTrainDelete.Click += new System.EventHandler(this.buttonTrainDelete_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(202, 546);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(103, 36);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // DeleteTrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonTrainDelete);
            this.Controls.Add(this.textBoxTrainName);
            this.Controls.Add(this.textBoxTrainNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "DeleteTrainForm";
            this.Text = "DeleteTrainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTrainNumber;
        private System.Windows.Forms.TextBox textBoxTrainName;
        private System.Windows.Forms.Button buttonTrainDelete;
        private System.Windows.Forms.Button buttonClose;
    }
}