namespace M12_inclass_template.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourthVers : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AlbumRecords", newName: "Albums");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Albums", newName: "AlbumRecords");
        }
    }
}
