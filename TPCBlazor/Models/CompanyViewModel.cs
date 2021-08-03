using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TPCBlazor.Models
{
    public class CompanyViewModel
    {
        [Key]
        public int Cid { get; set; }
        [Required(ErrorMessage = "Enter Company Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Company Location")]
        public string Location { get; set; }

        public string Criteria { get; set; }
        public string VisitingDate { get; set; }
        public string Package { get; set; }

        [Required(ErrorMessage = "Enter Role of position")]
        public string Role { get; set; }
    }
}
