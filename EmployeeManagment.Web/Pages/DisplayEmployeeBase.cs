using Microsoft.AspNetCore.Components;
using Views.DtoClasses;

namespace EmployeeManagment.Web.Pages
{
    public class DisplayEmployeeBase : ComponentBase
    {
        [Parameter]
        public EmployeeView Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }
    }
}
