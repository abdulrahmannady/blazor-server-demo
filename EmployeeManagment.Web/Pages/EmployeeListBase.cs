using EmployeeManagment.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Views.DtoClasses;

namespace EmployeeManagment.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public EmployeeService EmployeeService { get; set; }

        public IEnumerable<EmployeeView> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeService.GetEmployees();
        }
    }
}

