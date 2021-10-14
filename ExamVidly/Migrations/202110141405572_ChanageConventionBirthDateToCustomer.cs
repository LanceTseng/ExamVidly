namespace ExamVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChanageConventionBirthDateToCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.String());
        }
    }
}
