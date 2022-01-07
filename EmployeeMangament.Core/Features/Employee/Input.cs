using EmployeeManagment.EntityClasses;
using System;
using System.ComponentModel.DataAnnotations;
using Views.DtoClasses;

namespace EmployeeManagment.Core.Features.Employee
{
    public class EmployeeNewInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }
        public int DepartmentId { get; set; }
        public DTO.Department Department { get; set; } = new();

        public EmployeeNewInput()
        {

        }

        public EmployeeNewInput(EmployeeView e)
        {
            this.FirstName = e.FirstName;
            this.LastName = e.LastName;
            this.Email = e.Email;
            this.DateOfBirth = e.DateOfBirth;
            this.Gender = (Gender)e.Gender;
            this.PhotoPath = e.PhotoPath;
            this.DepartmentId = e.DepartmentId;
        }

        public EmployeeEntity ToEntity()
        {
            return new EmployeeEntity()
            {
                IsNew = true,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email,
                DateOfBirth = this.DateOfBirth,
                Gender = (int)this.Gender,
                PhotoPath = this.PhotoPath,
                DepartmentId = this.DepartmentId
            };
        }
    }
    public class EmployeeUpdateInput
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="First Name must be provided")]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        [EmailDomainValidator(AllowedDomain ="Nady.com",ErrorMessage ="Only Nady.com Domain allowed")]
        public string Email { get; set; }

        [CompareProperty(otherProperty: "Email", ErrorMessage ="Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string PhotoPath { get; set; }

        public int DepartmentId { get; set; }

        [ValidateComplexType]
        public DTO.Department Department { get; set; } = new();

        public EmployeeUpdateInput()
        {

        }

        public EmployeeUpdateInput(EmployeeView e)
        {
            this.Id = e.Id;
            this.FirstName = e.FirstName;
            this.LastName = e.LastName;
            this.Email = e.Email;
            this.DateOfBirth = e.DateOfBirth;
            this.Gender = (Gender)e.Gender;
            this.PhotoPath = e.PhotoPath;
            this.DepartmentId = e.DepartmentId;

            // this for testing complex type validation
            this.Department.NameEnglish = "HR";
        }

        public EmployeeEntity ToEntity()
        {
            return new EmployeeEntity()
            {
                IsNew = false,
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email,
                DateOfBirth = this.DateOfBirth,
                Gender = (int)this.Gender,
                PhotoPath = this.PhotoPath,
                DepartmentId = this.Department.Id
            };
        }
    }
}
