namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPictureToPost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "PostImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "PostImage");
        }
    }
}
