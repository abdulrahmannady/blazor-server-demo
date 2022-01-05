
namespace EmployeeManagement.Migration
{
    [FluentMigrator.Migration(0002)]
    public class _0002_CreateEmployeeTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table(Tables.Employee)
                .WithColumn(name: "Id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn(name: "FirstName").AsString(size: 250).NotNullable()
                .WithColumn(name: "LastName").AsString(size: 250).NotNullable()
                .WithColumn(name: "Email").AsString(size: 250).Nullable()
                .WithColumn(name: "DateOfBirth").AsDateTime().NotNullable()
                .WithColumn(name: "PhotoPath").AsString(size: 250).NotNullable()
                .WithColumn(name: "Gender").AsInt32().NotNullable()
                .WithColumn(name: "DepartmentId").AsInt32().ForeignKey(new ForginKeyName(Tables.Employee, Tables.Department).ToString(), Tables.Department, "Id").NotNullable()
                .WithColumn(name: "IsActive").AsBoolean().WithDefaultValue(value: true).NotNullable();
        }

        public override void Down()
        {
            Delete.Table(Tables.Employee);
        }
    }
}



