using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eisApi.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        
        [Column(TypeName ="nvarchar(50)")]
        public string DeptName { get; set; }

    }
}
