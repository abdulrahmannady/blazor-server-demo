using Microsoft.AspNetCore.Components;

namespace EmployeeManagment.Web.Pages
{
    public class DataBindingDemoBase : ComponentBase
    {
        public string Name { get; set; } = "Nady";
        public string Gender { get; set; } = "Male";
        public string Colour { get; set; } = "background-color:White";
    }
}
