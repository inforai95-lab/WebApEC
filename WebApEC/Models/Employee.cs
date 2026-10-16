using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApEC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Department { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
    }
}
