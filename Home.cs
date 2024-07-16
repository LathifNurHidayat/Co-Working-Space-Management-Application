using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Co_Working_Space_Management_Application
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        public void LoadForm(Form form)
        {
            // Pastikan ada kontrol yang dihapus jika panel memiliki kontrol
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }

            // Pastikan form bukan null
            if (form != null)
            {
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                panelMain.Controls.Add(form);
                panelMain.Tag = form;
                form.Show();
            }
            else
            {
                throw new ArgumentException("Parameter is not a Form", nameof(form));
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            Employee Em = new Employee();
            LoadForm(Em);
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Inventory In = new Inventory();
            LoadForm(In);
        }
    }
}
