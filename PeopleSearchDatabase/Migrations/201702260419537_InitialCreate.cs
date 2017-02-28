namespace PeopleSearchDatabase.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        StreetLine1 = c.String(),
                        StreetLine2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Interests = c.String(),
                        PictureUrl = c.String(),
                        Address_AddressId = c.Int(),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressId)
                .Index(t => t.Address_AddressId);
            
            CreateTable(
                "dbo.PeopleNameLookups",
                c => new
                    {
                        PeopleNameLookupId = c.Int(nullable: false, identity: true),
                        NamePart = c.String(maxLength: 40),
                        NameStart = c.Boolean(nullable: false),
                        Person_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.PeopleNameLookupId)
                .ForeignKey("dbo.People", t => t.Person_PersonId)
                .Index(t => t.NamePart, name: "NamePartIndex")
                .Index(t => t.Person_PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PeopleNameLookups", "Person_PersonId", "dbo.People");
            DropForeignKey("dbo.People", "Address_AddressId", "dbo.Addresses");
            DropIndex("dbo.PeopleNameLookups", new[] { "Person_PersonId" });
            DropIndex("dbo.PeopleNameLookups", "NamePartIndex");
            DropIndex("dbo.People", new[] { "Address_AddressId" });
            DropTable("dbo.PeopleNameLookups");
            DropTable("dbo.People");
            DropTable("dbo.Addresses");
        }
    }
}
