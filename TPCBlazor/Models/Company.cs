using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TPCBlazor.Models
{
    public class Company
    {
        [Key]
        public int Cid { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Criteria { get; set; }
        public string VisitingDate { get; set; }
        public string Package { get; set; }
        public string Role { get; set; }
    }
}
