using EmployeeManagment.EntityClasses;
using System;
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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }
        public int DepartmentId { get; set; }

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
            this.DepartmentId = DepartmentId;
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
                DepartmentId = this.DepartmentId
            };
        }
    }
}
