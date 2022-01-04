﻿using System;
using System.Collections.Generic;

namespace EmployeeManagement.Migration.Seed
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }

    }

    [FluentMigrator.Migration(1002)]
    public class _1002_SeedUsers : FluentMigrator.Migration
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                FirstName = "Amr",
                LastName = "Sayed",
                Email = "Amr@silverkey.com",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                PhotoPath = "fakepath/somePhoto1.jgp"
            },

            new Employee()
            {
                FirstName = "Abdulrahman",
                LastName = "Nady",
                Email = "Nady@silverkey.com",
                DateOfBirth = DateTime.Now,
                Gender = Gender.Male,
                PhotoPath = "fakepath/somePhoto2.jgp"
            }

        };

        public override void Up()
        {
            foreach (var e in employees)
            {
                Insert.IntoTable(Tables.Employee).Row(
                    new
                    {
                        FirstName =e.FirstName,
                        LastName = e.LastName ,
                        Email = e.Email,
                        DateOfBirth = e.DateOfBirth,
                        Gender = (int)e.Gender,
                        PhotoPath = e.PhotoPath,
                        IsActive = true
                    }
                );
            }
        }

        public override void Down()
        {
            //
        }
    }
}

