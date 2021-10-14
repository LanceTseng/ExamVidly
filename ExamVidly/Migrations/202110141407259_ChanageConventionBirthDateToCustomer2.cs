namespace ExamVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChanageConventionBirthDateToCustomer2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}
