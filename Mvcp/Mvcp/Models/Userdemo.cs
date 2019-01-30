using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvcp.Models
{
    public class UserDemo
    {

        public int UserDemoId { get; set; }
        [Required]
        [Display (Name="USER NAME")]
        public string username { get;set;}
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="PASSWORD")]
        public string password { get; set; }
    }
}