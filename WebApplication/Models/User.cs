using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class User
    {
        public int id;
        public string name;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
