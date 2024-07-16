namespace Co_Working_Space_Management_Application
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSignIn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            panel2 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Location = new Point(661, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 435);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(145, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 69);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Gray;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.GhostWhite;
            btnSignIn.Location = new Point(26, 314);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(337, 49);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(71, 219);
            label3.Name = "label3";
            label3.Size = new Size(87, 24);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(71, 138);
            label2.Name = "label2";
            label2.Size = new Size(88, 24);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(130, 75);
            label1.Name = "label1";
            label1.Size = new Size(129, 45);
            label1.TabIndex = 2;
            label1.Text = "Sign In";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.MenuBar;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 11F);
            tbPassword.Location = new Point(71, 244);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(249, 30);
            tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = SystemColors.MenuBar;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Segoe UI", 11F);
            tbUsername.Location = new Point(71, 165);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(249, 30);
            tbUsername.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-3, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 715);
            panel2.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Gray;
            panel10.ForeColor = SystemColors.ControlDark;
            panel10.Location = new Point(342, 227);
            panel10.Name = "panel10";
            panel10.Size = new Size(99, 16);
            panel10.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkGray;
            panel9.ForeColor = SystemColors.ControlDark;
            panel9.Location = new Point(239, 193);
            panel9.Name = "panel9";
            panel9.Size = new Size(202, 16);
            panel9.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightGray;
            panel8.ForeColor = SystemColors.ControlDark;
            panel8.Location = new Point(130, 159);
            panel8.Name = "panel8";
            panel8.Size = new Size(311, 16);
            panel8.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.ForeColor = SystemColors.ControlDark;
            panel7.Location = new Point(15, 122);
            panel7.Name = "panel7";
            panel7.Size = new Size(426, 16);
            panel7.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 23);
            label4.Name = "label4";
            label4.Size = new Size(446, 96);
            label4.TabIndex = 4;
            label4.Text = "Co-Working Space \r\nManagement Application";
            label4.Click += label4_Click;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom;
            panel6.BackColor = Color.Silver;
            panel6.Location = new Point(342, 503);
            panel6.Name = "panel6";
            panel6.Size = new Size(79, 209);
            panel6.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel5.BackColor = Color.DimGray;
            panel5.Location = new Point(15, 219);
            panel5.Name = "panel5";
            panel5.Size = new Size(89, 494);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.BackColor = Color.Gray;
            panel4.Location = new Point(130, 324);
            panel4.Name = "panel4";
            panel4.Size = new Size(84, 391);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom;
            panel3.BackColor = Color.DarkGray;
            panel3.Location = new Point(239, 410);
            panel3.Name = "panel3";
            panel3.Size = new Size(81, 303);
            panel3.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 710);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox tbUsername;
        private Label label1;
        private TextBox tbPassword;
        private Label label3;
        private Label label2;
        private Button btnSignIn;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
    }
}
