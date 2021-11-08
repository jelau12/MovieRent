namespace MovieRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreIdToMovieTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.String());
            DropColumn("dbo.Movies", "GenreId");
        }
    }
}
