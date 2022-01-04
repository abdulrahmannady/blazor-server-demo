using EmployeeManagment.DatabaseSpecific;
using EmployeeManagment.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Views.DtoClasses;
using Views.Persistence;

namespace EmployeeMangament.Core.Features.Employee
{
    public class Query
    {
        public async Task<IEnumerable<EmployeeView>> GetEmployees()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var e = metaData.Employee;

                if (e.Count() < 0)
                    return null;

                return await e.ProjectToEmployeeView().ToListAsync();
            }
        }

        public async Task<EmployeeView> GetEmploye(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var employee = await metaData.Employee.FirstOrDefaultAsync(x => x.Id == id);

                if (employee is null)
                    return null;

                return employee.ProjectToEmployeeView();
            }
        }
    }
}
