namespace M12_inclass_template.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class songsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        SongId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Length = c.Int(nullable: false),
                        ParentAlbum_AlbumId = c.Int(),
                    })
                .PrimaryKey(t => t.SongId)
                .ForeignKey("dbo.Albums", t => t.ParentAlbum_AlbumId)
                .Index(t => t.ParentAlbum_AlbumId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "ParentAlbum_AlbumId", "dbo.Albums");
            DropIndex("dbo.Songs", new[] { "ParentAlbum_AlbumId" });
            DropTable("dbo.Songs");
        }
    }
}
