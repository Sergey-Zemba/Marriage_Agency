namespace Marriage_Agency_Women_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Women",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        Country = c.String(),
                        City = c.String(),
                        Nationality = c.String(),
                        Religion = c.Int(nullable: false),
                        Job = c.String(),
                        Education = c.Int(nullable: false),
                        MaritalStatus = c.Int(nullable: false),
                        NumberOfChildren = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        EyeColor = c.Int(nullable: false),
                        HairColor = c.Int(nullable: false),
                        Smoking = c.Boolean(nullable: false),
                        Alcohol = c.Boolean(nullable: false),
                        DesiredAge = c.Int(nullable: false),
                        Hobby = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Skype = c.String(),
                        Facebook = c.String(),
                        Vk = c.String(),
                        Twitter = c.String(),
                        InternationalPassport = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Women");
        }
    }
}
