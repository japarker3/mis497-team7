namespace MVCAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedAthletemodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Athletes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        City = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Athletes");
        }
    }
}
