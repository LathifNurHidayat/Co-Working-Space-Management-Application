namespace Co_Working_Space_Management_Application
{
    partial class Inventory
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            UpdateButton = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            UpdateInventoryButton = new Button();
            SatuanBarangText = new TextBox();
            NamaBarangText = new TextBox();
            JumlahBarangText = new TextBox();
            IdBarangText = new TextBox();
            dataGridInventory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridInventory).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.inventory;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(28, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 67);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 29);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 26;
            label1.Text = "Inventory\r\n";
            // 
            // UpdateButton
            // 
            UpdateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UpdateButton.BackColor = Color.ForestGreen;
            UpdateButton.ForeColor = SystemColors.ControlLightLight;
            UpdateButton.Location = new Point(180, 900);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(102, 35);
            UpdateButton.TabIndex = 6;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 248);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 9;
            label5.Text = "Jumlah Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 175);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 8;
            label4.Text = "Satuan Barang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 99);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 7;
            label3.Text = "Nama Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(17, 19);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 6;
            label2.Text = "Id Barang";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(IdBarangText);
            panel1.Controls.Add(JumlahBarangText);
            panel1.Controls.Add(NamaBarangText);
            panel1.Controls.Add(UpdateInventoryButton);
            panel1.Controls.Add(SatuanBarangText);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(753, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 536);
            panel1.TabIndex = 25;
            // 
            // UpdateInventoryButton
            // 
            UpdateInventoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UpdateInventoryButton.BackColor = Color.ForestGreen;
            UpdateInventoryButton.ForeColor = SystemColors.ControlLightLight;
            UpdateInventoryButton.Location = new Point(132, 330);
            UpdateInventoryButton.Name = "UpdateInventoryButton";
            UpdateInventoryButton.Size = new Size(102, 35);
            UpdateInventoryButton.TabIndex = 12;
            UpdateInventoryButton.Text = "Update";
            UpdateInventoryButton.UseVisualStyleBackColor = false;
            // 
            // SatuanBarangText
            // 
            SatuanBarangText.Location = new Point(18, 203);
            SatuanBarangText.Name = "SatuanBarangText";
            SatuanBarangText.Size = new Size(216, 31);
            SatuanBarangText.TabIndex = 10;
            // 
            // NamaBarangText
            // 
            NamaBarangText.Location = new Point(18, 127);
            NamaBarangText.Name = "NamaBarangText";
            NamaBarangText.Size = new Size(216, 31);
            NamaBarangText.TabIndex = 13;
            // 
            // JumlahBarangText
            // 
            JumlahBarangText.Location = new Point(18, 276);
            JumlahBarangText.Name = "JumlahBarangText";
            JumlahBarangText.Size = new Size(216, 31);
            JumlahBarangText.TabIndex = 14;
            // 
            // IdBarangText
            // 
            IdBarangText.Location = new Point(18, 47);
            IdBarangText.Name = "IdBarangText";
            IdBarangText.Size = new Size(216, 31);
            IdBarangText.TabIndex = 15;
            // 
            // dataGridInventory
            // 
            dataGridInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInventory.Location = new Point(24, 82);
            dataGridInventory.Name = "dataGridInventory";
            dataGridInventory.RowHeadersWidth = 62;
            dataGridInventory.Size = new Size(710, 428);
            dataGridInventory.TabIndex = 28;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 640);
            Controls.Add(dataGridInventory);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventory";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label12;
        private TextBox AlamatAddText;
        private Label label7;
        private Button AddButton;
        private Label label8;
        private DateTimePicker TanggalLahirAddPicker;
        private Label label11;
        private TextBox NamaAddText;
        private Label label9;
        private Label label10;
        private TextBox IdAddtext;
        private ComboBox JenisKelaminAddCombo;
        private PictureBox pictureBox1;
        private Label label1;
        private Button UpdateButton;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private TextBox NamaText;
        private TextBox IdText;
        private DataGridView dataGridEmployee;
        private TextBox textBox2;
        private TextBox SatuanBarangText;
        private Button UpdateInventoryButton;
        private TextBox IdBarangText;
        private TextBox JumlahBarangText;
        private TextBox NamaBarangText;
        private DataGridView dataGridInventory;
    }
}