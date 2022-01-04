using EmployeeManagment.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
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

        protected string Coordinates { get; set; }
        protected string ButtonText { get; set; } = "Hide Footer";
        protected string CssClass { get; set; } = null;

        public EmployeeView Employee { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }

        protected void Button_Click()
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "hide-footer";
            }
            else
            {
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }
    }
}
