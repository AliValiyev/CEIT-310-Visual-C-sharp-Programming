namespace M12_inclass_template.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdVersion : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.AlbumRecords");
            AddColumn("dbo.AlbumRecords", "AlbumId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.AlbumRecords", "AlbumId");
            DropColumn("dbo.AlbumRecords", "MyItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AlbumRecords", "MyItemId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.AlbumRecords");
            DropColumn("dbo.AlbumRecords", "AlbumId");
            AddPrimaryKey("dbo.AlbumRecords", "MyItemId");
        }
    }
}
