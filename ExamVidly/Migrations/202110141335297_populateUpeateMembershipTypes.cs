namespace ExamVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateUpeateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET Name = 'Pay as You Go' Where DurationInMonths = 0");
            Sql("Update MembershipTypes SET Name = 'Monthly' Where DurationInMonths > 0");
        }
        
        public override void Down()
        {
        }
    }
}
