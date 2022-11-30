namespace M12_inclass_template.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondVersion : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Albums", newName: "AlbumRecords");
            RenameColumn(table: "dbo.AlbumRecords", name: "Released", newName: "ReleasedDate");
            DropPrimaryKey("dbo.AlbumRecords");
            AddColumn("dbo.AlbumRecords", "MyItemId", c => c.Int(nullable: false, identity: false)); // We changed identity to false to solve Multiple identity columns specified for table 'AlbumRecords'...
            AddColumn("dbo.AlbumRecords", "AlbumName", c => c.String(maxLength: 150));
            AlterColumn("dbo.AlbumRecords", "Length", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.AlbumRecords", "MyItemId");
            DropColumn("dbo.AlbumRecords", "AlbumId");
            DropColumn("dbo.AlbumRecords", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AlbumRecords", "Name", c => c.String());
            AddColumn("dbo.AlbumRecords", "AlbumId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.AlbumRecords");
            AlterColumn("dbo.AlbumRecords", "Length", c => c.Double(nullable: false));
            DropColumn("dbo.AlbumRecords", "AlbumName");
            DropColumn("dbo.AlbumRecords", "MyItemId");
            AddPrimaryKey("dbo.AlbumRecords", "AlbumId");
            RenameColumn(table: "dbo.AlbumRecords", name: "ReleasedDate", newName: "Released");
            RenameTable(name: "dbo.AlbumRecords", newName: "Albums");
        }
    }
}
