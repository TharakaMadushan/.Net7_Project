using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHRMS.Entity.Entity
{
    public class EmployeeMaster
    {
        [Key]
        public int EmployeeNo { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(150)]
        public string Address1 { get; set; }
        [MaxLength(150)]
        public string Address2 { get; set; }
        [MaxLength(150)]
        public string Address3 { get; set; }
        [MaxLength(150)]
        public string Address4 { get; set; }
        [MaxLength(150)]
        public string Designation { get; set; }
        public DateTime DOB { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Required]
        public decimal Basicsalary { get; set; }
    }
}
