namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixComments : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Comments", name: "PostId", newName: "PostId_PostId");
            RenameIndex(table: "dbo.Comments", name: "IX_PostId", newName: "IX_PostId_PostId");
            AlterColumn("dbo.Comments", "CommentSubject", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "CommentSubject", c => c.String());
            RenameIndex(table: "dbo.Comments", name: "IX_PostId_PostId", newName: "IX_PostId");
            RenameColumn(table: "dbo.Comments", name: "PostId_PostId", newName: "PostId");
        }
    }
}
