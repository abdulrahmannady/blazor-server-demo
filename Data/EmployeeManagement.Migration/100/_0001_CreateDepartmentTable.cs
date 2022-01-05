
namespace EmployeeManagement.Migration
{
    [FluentMigrator.Migration(0001)]
    public class _0001_CreateDepartmentTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table(Tables.Department)
                .WithColumn(name: "Id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn(name: "NameEnglish").AsString(size: 250).NotNullable()
                .WithColumn(name: "IsActive").AsBoolean().WithDefaultValue(value: true).NotNullable();
        }

        public override void Down()
        {
            Delete.Table(Tables.Department);
        }
    }
}



