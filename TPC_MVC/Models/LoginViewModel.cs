using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TPC_MVC.Models
{
    public class LoginViewModel
    {
        [Key]
        public int Uid { get; set; }
        [Required(ErrorMessage = "Username is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        
    }
}
