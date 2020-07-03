using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace eisApi.Models
{
    
    public class ApplicationUser : IdentityUser
    {
        [Column(TypeName ="nvarchar(100)")]
        public string FullName { get; set; }
        public virtual ICollection<EmployeeDetail> EmployeeDetails { get; set; }

    }

   
}

