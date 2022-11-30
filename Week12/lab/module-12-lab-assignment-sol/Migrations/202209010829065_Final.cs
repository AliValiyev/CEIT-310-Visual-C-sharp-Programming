namespace M12_inclass_template.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Songs", "ParentAlbum_AlbumId", "dbo.Albums");
            DropIndex("dbo.Songs", new[] { "ParentAlbum_AlbumId" });
            RenameColumn(table: "dbo.Songs", name: "ParentAlbum_AlbumId", newName: "AlbumId");
            AlterColumn("dbo.Songs", "AlbumId", c => c.Int(nullable: false));
            CreateIndex("dbo.Songs", "AlbumId");
            AddForeignKey("dbo.Songs", "AlbumId", "dbo.Albums", "AlbumId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "AlbumId", "dbo.Albums");
            DropIndex("dbo.Songs", new[] { "AlbumId" });
            AlterColumn("dbo.Songs", "AlbumId", c => c.Int());
            RenameColumn(table: "dbo.Songs", name: "AlbumId", newName: "ParentAlbum_AlbumId");
            CreateIndex("dbo.Songs", "ParentAlbum_AlbumId");
            AddForeignKey("dbo.Songs", "ParentAlbum_AlbumId", "dbo.Albums", "AlbumId");
        }
    }
}
