using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Data.SqlClient;

namespace EmployeeManagment.Api
{
    public class Conf
    {
        public static void LLBLGen()
        {
            RuntimeConfiguration.AddConnectionString("ConnectionString.SQL Server (SqlClient)", "Server=.\\SQLEXPRESS;Database=FluentMigratorDemo;Trusted_Connection=True;");
            RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(c =>
            {
                c.AddDbProviderFactory(typeof(SqlClientFactory));
            });
        }
    }
}