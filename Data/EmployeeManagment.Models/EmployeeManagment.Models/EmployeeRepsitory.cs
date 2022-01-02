namespace EmployeeManagment.Models
{
    public static class EmployeeRepsitory
    {
        public static async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await Task.Run(SimulateLoadingEmployeesFromDb);
        }
        private static IEnumerable<Employee> SimulateLoadingEmployeesFromDb()
        {
            System.Threading.Thread.Sleep(3000);
            return new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = 1,
                    FirstName = "Nady",
                    LastName = "Ahmed",
                    Email = "Ahmed@gmail.com",
                    DateOfBirth = new DateTime(1980, 10, 5),
                    Gender = Gender.Male,
                    Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                    PhotoPath = "images/stonks.jpg"
                },
                new Employee()
                {
                    EmployeeId = 2,
                    FirstName = "Nour",
                    LastName = "Sayed",
                    Email = "Nour@gmail.com",
                    DateOfBirth = new DateTime(1981, 12, 22),
                    Gender = Gender.Female,
                    Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
                    PhotoPath = "images/female.jpg"
                }
            };
        }
    }
}
