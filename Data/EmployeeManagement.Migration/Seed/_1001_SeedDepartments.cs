using FluentMigrator;

namespace EmployeeManagement.Migration.Seed
{
    [FluentMigrator.Migration(1001)]
    public class _1001_SeedDepartments : FluentMigrator.Migration
    {
        public override void Up()
        {
            Execute.Sql(@"SET IDENTITY_INSERT dbo.Department ON;");

            Insert.IntoTable(Tables.Department).Row(
                    new
                    {
                        Id = (short)Department.IT,
                        NameEnglish = "IT",
                        IsActive = true
                    });

            Insert.IntoTable(Tables.Department).Row(
                    new
                    {
                        Id = (short)Department.HR,
                        NameEnglish = "HR",
                        IsActive = true
                    });

            Execute.Sql(@"SET IDENTITY_INSERT dbo.Department OFF;");
        }
        public override void Down()
        {
            //
        }
    }
}
