using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Model.Entity
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Employee Name is requiered")]
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public double EmployeeSalary { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public String Note { get; set; }
        public List<Department> Departments { get; set; }
    }
}
