using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eisApi.Models
{
    public class EmployeeDetail
    {

        [Key]
        public int EmplID { get; set; }
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual ApplicationUser User { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public String FirstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public String LastName { get; set; }
        [Column(TypeName = "int")]
        public int DeptID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public String Email { get; set; }
        [Column(TypeName = "date")]
        public DateTime DOB { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public String Project { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public String Contact { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public String EmrgncyContact { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public String Address { get; set; }
        [Column(TypeName = "int")]
        public int WorkHours { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public String Pancard { get; set; }
        [Column(TypeName = "int")]
        public int PTO { get; set; }

        [ForeignKey("DeptID")]
        public Department Department { get; set; }
    }
}
