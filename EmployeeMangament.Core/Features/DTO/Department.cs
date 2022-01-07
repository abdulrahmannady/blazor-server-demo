using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Core.Features.DTO
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        public string NameEnglish { get; set; }
    }
}
