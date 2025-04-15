using FluentMigrator;


namespace scooters_api.Data.Migrations
{
    [Migration(05042025)]

    public class CreateSchema : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("car")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("brand").AsString(120).NotNullable()
                .WithColumn("modelType").AsString(120).NotNullable()
                .WithColumn("horsePower").AsInt32().NotNullable()
                .WithColumn("range").AsInt32().NotNullable()
                .WithColumn("maxSpeed").AsInt32().NotNullable();
        }
    }
}
