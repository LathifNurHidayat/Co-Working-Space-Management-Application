namespace Co_Working_Space_Management_Application
{
    partial class Home
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
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            ReportButton = new Button();
            EmployeeButton = new Button();
            DashboardButton = new Button();
            InventoryButton = new Button();
            panelMain = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1259, 74);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(85, 74);
            panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(6, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 72);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(85, 12);
            label4.Name = "label4";
            label4.Size = new Size(688, 45);
            label4.TabIndex = 6;
            label4.Text = "Co-Working Space Management Application";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(ReportButton);
            panel2.Controls.Add(EmployeeButton);
            panel2.Controls.Add(DashboardButton);
            panel2.Controls.Add(InventoryButton);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 713);
            panel2.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(0, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 23);
            linkLabel1.TabIndex = 0;
            // 
            // ReportButton
            // 
            ReportButton.BackColor = Color.Gray;
            ReportButton.FlatAppearance.BorderSize = 0;
            ReportButton.FlatStyle = FlatStyle.Flat;
            ReportButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportButton.ForeColor = SystemColors.Control;
            ReportButton.Image = Properties.Resources.report;
            ReportButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReportButton.Location = new Point(4, 296);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(232, 70);
            ReportButton.TabIndex = 9;
            ReportButton.Text = "        Report";
            ReportButton.TextAlign = ContentAlignment.MiddleLeft;
            ReportButton.UseVisualStyleBackColor = false;
            // 
            // EmployeeButton
            // 
            EmployeeButton.BackColor = Color.Gray;
            EmployeeButton.FlatAppearance.BorderSize = 0;
            EmployeeButton.FlatStyle = FlatStyle.Flat;
            EmployeeButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeButton.ForeColor = SystemColors.Control;
            EmployeeButton.Image = Properties.Resources.employee__1_;
            EmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            EmployeeButton.Location = new Point(3, 220);
            EmployeeButton.Name = "EmployeeButton";
            EmployeeButton.Size = new Size(233, 70);
            EmployeeButton.TabIndex = 7;
            EmployeeButton.Text = "        Employee Data";
            EmployeeButton.TextAlign = ContentAlignment.MiddleLeft;
            EmployeeButton.UseVisualStyleBackColor = false;
            EmployeeButton.Click += EmployeeButton_Click;
            // 
            // DashboardButton
            // 
            DashboardButton.BackColor = Color.Gray;
            DashboardButton.BackgroundImageLayout = ImageLayout.Zoom;
            DashboardButton.FlatAppearance.BorderSize = 0;
            DashboardButton.FlatStyle = FlatStyle.Flat;
            DashboardButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardButton.ForeColor = SystemColors.Control;
            DashboardButton.Image = Properties.Resources.dashboard__1_;
            DashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardButton.Location = new Point(3, 68);
            DashboardButton.Name = "DashboardButton";
            DashboardButton.Size = new Size(233, 70);
            DashboardButton.TabIndex = 6;
            DashboardButton.Text = "        Dashboard";
            DashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            DashboardButton.UseVisualStyleBackColor = false;
            // 
            // InventoryButton
            // 
            InventoryButton.BackColor = Color.Gray;
            InventoryButton.FlatAppearance.BorderSize = 0;
            InventoryButton.FlatStyle = FlatStyle.Flat;
            InventoryButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventoryButton.ForeColor = SystemColors.Control;
            InventoryButton.Image = Properties.Resources.inventory;
            InventoryButton.ImageAlign = ContentAlignment.MiddleLeft;
            InventoryButton.Location = new Point(3, 144);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(232, 70);
            InventoryButton.TabIndex = 7;
            InventoryButton.Text = "        Inventory";
            InventoryButton.TextAlign = ContentAlignment.MiddleLeft;
            InventoryButton.UseVisualStyleBackColor = false;
            InventoryButton.Click += InventoryButton_Click;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.Location = new Point(241, 77);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1015, 621);
            panelMain.TabIndex = 6;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 710);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Button DashboardButton;
        private Button EmployeeButton;
        private Button InventoryButton;
        private Button ReportButton;
        private Panel panel3;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Panel panelMain;
    }
}