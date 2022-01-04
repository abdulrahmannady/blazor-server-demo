using EmployeeManagment.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Views.DtoClasses;

namespace EmployeeManagment.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        [Inject]
        public EmployeeService EmployeeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public EmployeeView Employee { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }
    }
}
