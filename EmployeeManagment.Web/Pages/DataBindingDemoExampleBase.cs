using Microsoft.AspNetCore.Components;

namespace EmployeeManagment.Web.Pages
{
    public class DataBindingDemoExampleBase : ComponentBase
    {
        protected string TextArea { get; set; } = string.Empty;

        protected int Counter { get; set; }
    }
}
