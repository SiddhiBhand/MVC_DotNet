using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CURDOperations.Models
{
    public class EmployeeViewModel
    {
        [Key]
        [Required(ErrorMessage ="Enter Id")]
        public int EmpId { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string EmpName { get; set; }
        public int Age { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
    }
}
