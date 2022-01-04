
namespace EmployeeManagement.Migration
{
    [FluentMigrator.Migration(0001)]
    public class _0001_CreateEmployeeTable : FluentMigrator.Migration
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
                .WithColumn(name: "IsActive").AsBoolean().WithDefaultValue(value: true).NotNullable();
        }

        public override void Down()
        {
            Delete.Table(tableName: "User");
        }
    }
}



