namespace BlogMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTipoContenido : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Contenido", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Contenido", c => c.Int(nullable: false));
        }
    }
}
