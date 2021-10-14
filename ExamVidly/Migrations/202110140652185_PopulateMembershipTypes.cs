namespace ExamVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Signupfee, Durationinmonths, Discountrate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Signupfee, Durationinmonths, Discountrate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, Signupfee, Durationinmonths, Discountrate) VALUES (3, 90, 3, 50)");
            Sql("INSERT INTO MembershipTypes (Id, Signupfee, Durationinmonths, Discountrate) VALUES (4, 300, 4, 20)");
        }

        public override void Down()
        {
        }
    }
}
