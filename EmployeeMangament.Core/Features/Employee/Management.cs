using EmployeeManagment.DatabaseSpecific;
using EmployeeManagment.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;
using System.Threading.Tasks;
using Views.DtoClasses;
using Views.Persistence;

namespace EmployeeMangament.Core.Features.Employee
{
    public class Management
    {
        public async Task<EmployeeView> Create(EmployeeNewInput input)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var e = input.ToEntity();
                await adapter.SaveEntityAsync(e, refetchAfterSave: true);
                return e.ProjectToEmployeeView();
            }
        }

        public async Task<EmployeeView> Update(EmployeeUpdateInput input)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var employee = await metaData.Employee.FirstOrDefaultAsync(x => x.Id == input.Id);

                if (employee is null)
                    return null;

                var e = input.ToEntity();
                await adapter.SaveEntityAsync(e, refetchAfterSave: true);

                return e.ProjectToEmployeeView();
            }
        }

        public async Task<EmployeeView> Delete(int id)
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var employee = await metaData.Employee.FirstOrDefaultAsync(x => x.Id == id);

                if (employee is null)
                    return null;

                await adapter.DeleteEntityAsync(employee);

                return employee.ProjectToEmployeeView();
            }
        }
    }
}
