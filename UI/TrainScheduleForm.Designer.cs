
namespace TrainManagementSystemGUI.UI
{
    partial class TrainScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainScheduleForm));
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TrainNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.LightGreen;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(1063, 661);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(143, 49);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrainNumber,
            this.TrainName,
            this.TrainOrigin,
            this.TrainDestination,
            this.TrainCategory,
            this.TrainFare,
            this.TrainDeparture});
            this.dataGridView1.GridColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.Location = new System.Drawing.Point(53, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 522);
            this.dataGridView1.TabIndex = 2;
            // 
            // TrainNumber
            // 
            this.TrainNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainNumber.DataPropertyName = "TrainNumber";
            this.TrainNumber.HeaderText = "TrainNumber";
            this.TrainNumber.Name = "TrainNumber";
            this.TrainNumber.ReadOnly = true;
            // 
            // TrainName
            // 
            this.TrainName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainName.DataPropertyName = "TrainName";
            this.TrainName.HeaderText = "Train Name";
            this.TrainName.Name = "TrainName";
            this.TrainName.ReadOnly = true;
            // 
            // TrainOrigin
            // 
            this.TrainOrigin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainOrigin.DataPropertyName = "Origin";
            this.TrainOrigin.HeaderText = "Train Origin";
            this.TrainOrigin.Name = "TrainOrigin";
            this.TrainOrigin.ReadOnly = true;
            // 
            // TrainDestination
            // 
            this.TrainDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainDestination.DataPropertyName = "Destination";
            this.TrainDestination.HeaderText = "Train Destination";
            this.TrainDestination.Name = "TrainDestination";
            this.TrainDestination.ReadOnly = true;
            // 
            // TrainCategory
            // 
            this.TrainCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainCategory.DataPropertyName = "Category";
            this.TrainCategory.HeaderText = "Train Category";
            this.TrainCategory.Name = "TrainCategory";
            this.TrainCategory.ReadOnly = true;
            // 
            // TrainFare
            // 
            this.TrainFare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainFare.DataPropertyName = "Fare";
            this.TrainFare.HeaderText = "Train Fare";
            this.TrainFare.Name = "TrainFare";
            this.TrainFare.ReadOnly = true;
            // 
            // TrainDeparture
            // 
            this.TrainDeparture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainDeparture.DataPropertyName = "Departure";
            this.TrainDeparture.HeaderText = "Train Departure";
            this.TrainDeparture.Name = "TrainDeparture";
            this.TrainDeparture.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "TRAIN MANAGEMENT SYSTEM";
            // 
            // TrainScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClose);
            this.DoubleBuffered = true;
            this.Name = "TrainScheduleForm";
            this.Text = "TrainScheduleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainFare;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainDeparture;
    }
}