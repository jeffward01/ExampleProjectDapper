namespace Dapper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Artist", newName: "Artists");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Artists", newName: "Artist");
        }
    }
}
