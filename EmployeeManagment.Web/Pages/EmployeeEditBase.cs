using EmployeeManagment.Web.Services;
using EmployeeManagment.Core.Features.Employee;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Views.DtoClasses;

namespace EmployeeManagment.Web.Pages
{
    public class EmployeeEditBase : ComponentBase
    {
        [Inject]
        public EmployeeService EmployeeService { get; set; }

        [Inject]
        public DepartmentService DepartmentService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public EmployeeUpdateInput Input { get; set; } = new();

        public List<DepartmentView> Departments { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            Input = new(await EmployeeService.GetEmployee(int.Parse(Id)));

            Departments = await DepartmentService.GetDepartments();

            await base.OnInitializedAsync();
        }

        protected async Task HandelValidSubmit()
        {
            //Input.ToEntity();
            //EmployeeService.
        }
    }
}
