using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Registration.Models
{
    public class Reg
    {
        public int RegId { get; set; }
        [Required]
        public string rname { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}