using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class Dept
    {
        public int DeptId { get; set; }
        [Required]
        public string Deptname { get; set; }
    }
}