using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json.Nodes;

namespace Co_Working_Space_Management_Application
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            ListData();


            JenisKelaminAddCombo.Items.Add("Laki-laki");
            JenisKelaminAddCombo.Items.Add("Perempuan");


            JenisKelaminCombo.Items.Add("Laki-laki");
            JenisKelaminCombo.Items.Add("Perempuan");

        }





        public void ListData()
        {
            using var db = new ConnDbContext();
            var listData = db.TB_Employee.ToList();
            dataGridEmployee.DataSource = listData;

        }




        private void dataGridEmployee_SelectionChanged(object sender, EventArgs e)
        {
            var EmployeeId = dataGridEmployee.CurrentRow.Cells["id"].Value.ToString();

            if (EmployeeId is null)
            {
                return;
            }
            using var db = new ConnDbContext();
            var employee = db.TB_Employee.Find(int.Parse(EmployeeId));
            ShowUpdate(employee);

        }

        public void ShowUpdate(EmployeeModel employee)
        {
            IdText.Text = employee.id.ToString();
            NamaText.Text = employee.nama;
            JenisKelaminCombo.SelectedItem = employee.jenis_kelamin;
            TglLahirPicker.Value = employee.tgl_lahir;
            AlamatText.Text = employee.alamat;

        }

       

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddList();
        }

        public void AddList()
        {
            var employee = new EmployeeModel
            {
                nama = NamaAddText.Text,
                tgl_lahir = TanggalLahirAddPicker.Value,
                jenis_kelamin = JenisKelaminAddCombo.SelectedItem.ToString(),
                alamat = AlamatAddText.Text

            };

            using var db = new ConnDbContext();
            db.TB_Employee.Add(employee);
            db.SaveChanges();

            ListData();

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            using var db = new ConnDbContext();
            var employee = db.TB_Employee.Find(int.Parse(IdText.Text));

            employee.nama = NamaText.Text; ;
            employee.jenis_kelamin = JenisKelaminCombo.SelectedItem.ToString();
            employee.tgl_lahir = TglLahirPicker.Value;
            employee.alamat = AlamatText.Text;

            db.SaveChanges();
            ListData();
        }
    }
}   