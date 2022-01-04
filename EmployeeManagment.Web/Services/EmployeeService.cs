using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Views.DtoClasses;

namespace EmployeeManagment.Web.Services
{
    public class EmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<EmployeeView>> GetEmployees()
        {
            try
            {
                return await httpClient.GetFromJsonAsync<EmployeeView[]>("api/employee");
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
