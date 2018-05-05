namespace SDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodaniePolaNazwaPlikuZdjecia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "NazwaPlikuZdjecia", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "NazwaPlikuZdjecia");
        }
    }
}
