using EmployeeManagment.EntityClasses;
using System;
using Views.DtoClasses;

namespace EmployeeMangament.Core.Features.Employee
{
    public class EmployeeNewInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }

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
        }

        public EmployeeEntity ToEntity()
        {
            return new EmployeeEntity()
            {
                IsNew = true,
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                DateOfBirth = DateOfBirth,
                Gender = (int)Gender,
                PhotoPath = PhotoPath
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
        }

        public EmployeeEntity ToEntity()
        {
            return new EmployeeEntity()
            {
                IsNew = false,
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                DateOfBirth = DateOfBirth,
                Gender = (int)Gender,
                PhotoPath = PhotoPath
            };
        }
    }
}
