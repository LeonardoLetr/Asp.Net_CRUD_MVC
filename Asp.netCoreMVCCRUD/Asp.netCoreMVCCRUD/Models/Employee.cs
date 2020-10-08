using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "varchar(250)")]
        [Required(ErrorMessage = "campo obrigatorio*")]
        [DisplayName("Nome Completo")]
        public string FullName { get; set; }
        
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Fun. Code")]
        public string EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Cargo")]
        public string Position { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Endereço")]
        public string OfficeLocation { get; set; }
    }
}
