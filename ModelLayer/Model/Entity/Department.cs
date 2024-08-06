using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Model.Entity
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        [Required(ErrorMessage ="department name is requiered")]
        [Column("dept_name")]
        public string DepartmentName { get; set; }
        [Required(ErrorMessage = "department location is requiered")]
        [Column("dept_loc")]
        public string DepartmentLocation { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
