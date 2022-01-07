using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Views.DtoClasses;

namespace EmployeeManagment.Web.Services
{
    public class DepartmentService
    {
        private readonly HttpClient httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<DepartmentView>> GetDepartments()
        {
            try
            {
                return await httpClient.GetFromJsonAsync<List<DepartmentView>>("api/department");
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        public async Task<DepartmentView> GetDepartment(int id)
        {
            try
            {
                return await httpClient.GetFromJsonAsync<DepartmentView>($"api/department/{id}");
            }
            catch (System.Exception e)
            {

                throw;
            }
            
        }
    }
}
