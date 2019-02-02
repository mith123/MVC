using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class Stud
    {
        public int StudId { get; set; }
        public int DepId{get;set;}
        public virtual Dept Dept{get;set;}
         public int RegId{get;set;}
        public virtual Reg Reg{get;set;}
        [Required]
        public string sname { get; set; }

     
    }
}