namespace Co_Working_Space_Management_Application
{
    partial class Employee
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            panel1 = new Panel();
            ButtonUpdate = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            AlamatText = new TextBox();
            TglLahirPicker = new DateTimePicker();
            JenisKelaminCombo = new ComboBox();
            NamaText = new TextBox();
            IdText = new TextBox();
            dataGridEmployee = new DataGridView();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1020, 640);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dataGridEmployee);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1012, 602);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Data Employee";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 26);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 11;
            label1.Text = "Employee Data";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(ButtonUpdate);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AlamatText);
            panel1.Controls.Add(TglLahirPicker);
            panel1.Controls.Add(JenisKelaminCombo);
            panel1.Controls.Add(NamaText);
            panel1.Controls.Add(IdText);
            panel1.Location = new Point(743, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 460);
            panel1.TabIndex = 10;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(120, 415);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(112, 34);
            ButtonUpdate.TabIndex = 11;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 263);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 10;
            label6.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 201);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 9;
            label5.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 137);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 8;
            label4.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 75);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 7;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(16, 13);
            label2.Name = "label2";
            label2.Size = new Size(27, 25);
            label2.TabIndex = 6;
            label2.Text = "id";
            // 
            // AlamatText
            // 
            AlamatText.Location = new Point(16, 291);
            AlamatText.Multiline = true;
            AlamatText.Name = "AlamatText";
            AlamatText.Size = new Size(216, 109);
            AlamatText.TabIndex = 5;
            // 
            // TglLahirPicker
            // 
            TglLahirPicker.Format = DateTimePickerFormat.Short;
            TglLahirPicker.Location = new Point(16, 229);
            TglLahirPicker.Name = "TglLahirPicker";
            TglLahirPicker.Size = new Size(216, 31);
            TglLahirPicker.TabIndex = 4;
            // 
            // JenisKelaminCombo
            // 
            JenisKelaminCombo.FormattingEnabled = true;
            JenisKelaminCombo.Location = new Point(16, 165);
            JenisKelaminCombo.Name = "JenisKelaminCombo";
            JenisKelaminCombo.Size = new Size(216, 33);
            JenisKelaminCombo.TabIndex = 3;
            // 
            // NamaText
            // 
            NamaText.Location = new Point(16, 103);
            NamaText.Name = "NamaText";
            NamaText.Size = new Size(216, 31);
            NamaText.TabIndex = 2;
            // 
            // IdText
            // 
            IdText.Location = new Point(16, 41);
            IdText.Name = "IdText";
            IdText.ReadOnly = true;
            IdText.Size = new Size(216, 31);
            IdText.TabIndex = 1;
            // 
            // dataGridEmployee
            // 
            dataGridEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridEmployee.BackgroundColor = Color.Silver;
            dataGridEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmployee.Location = new Point(24, 78);
            dataGridEmployee.Name = "dataGridEmployee";
            dataGridEmployee.RowHeadersWidth = 62;
            dataGridEmployee.Size = new Size(713, 460);
            dataGridEmployee.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.employee__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(9, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 67);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1012, 602);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Input Data";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 640);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            Text = "x";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private Button UpdateButton;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox AlamatText;
        private DateTimePicker TglLahirPicker;
        private ComboBox JenisKelaminCombo;
        private TextBox NamaText;
        private TextBox IdText;
        private DataGridView dataGridEmployee;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private Button ButtonUpdate;
    }
}