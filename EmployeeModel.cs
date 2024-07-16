using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co_Working_Space_Management_Application
{
    public class EmployeeModel
    {

        [Key]
        public int id { get; set; }
        public string nama { get; set; }=string.Empty;
        public string jenis_kelamin { get; set; } = string.Empty;
        public DateTime tgl_lahir { get; set; } = new DateTime(1900,04,05);
        public string alamat { get; set; } = string.Empty;

    }

    
}
