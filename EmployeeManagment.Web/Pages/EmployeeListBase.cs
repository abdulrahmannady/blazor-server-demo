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

        public bool ShowFooter { get; set; } = true;

        public int Counter { get; set; }

        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
                Counter++;
            else
                Counter--;
        }

        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeService.GetEmployees();
        }
    }
}

