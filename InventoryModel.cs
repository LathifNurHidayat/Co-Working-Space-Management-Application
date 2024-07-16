using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co_Working_Space_Management_Application
{
    public class InventoryModel

    {
        [Key]
        public int IdBarang { get; set; }
        public string NamaBarang { get; set; } = string.Empty;
        public string SatuanBarang { get; set; } = string.Empty;
        public int JumlahBarang { get; set; }

    }
}
