using EmployeeManagment.DatabaseSpecific;
using EmployeeManagment.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Views.DtoClasses;
using Views.Persistence;

namespace EmployeeManagment.Core.Features.Department
{
    public class Query
    {
        public async Task<IEnumerable<DepartmentView>> GetDepartments()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var e = metaData.Department;

                if (e.Count() < 0)
                    return null;

                return await e.ProjectToDepartmentView().ToListAsync();
            }
        }

        public async Task<DepartmentView> GetDepartment(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var e = await metaData.Department.FirstOrDefaultAsync(x => x.Id == id);

                if (e is null)
                    return null;

                return e.ProjectToDepartmentView();
            }
        }
    }
}
