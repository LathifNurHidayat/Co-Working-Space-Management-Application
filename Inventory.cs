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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            ListInventory();
        }

        public void ListInventory()
        {
            using var db = new ConnDbContext();
            var listInventory = db.TB_Inventaris.ToList(); 
            dataGridInventory.DataSource = listInventory;
        }
    }
}
