namespace ExamVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9c9dd21b-b9f1-45bf-a9cf-21b242750553', N'admin@vidly.com', 0, N'AHeLSi3YX0dcZzaEsmi/RSaG8SVTlM28WVn48gb27JiqQAs5XnbOXWNlaTrUOmRQpA==', N'da6ff8e5-eeb2-48ae-b7ab-8ca159e35753', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9d7082c7-f0ac-4a0b-9600-c22c982b0b03', N'guest@vidly.com', 0, N'AOnd/dl/fYTotHREHPYeiUXxQyA4i57EveT1m2EGAHaLi12RlYOQXVqQOPdtZP6E9Q==', N'41736d7b-0df6-419b-8d5c-b945cb055465', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6ecd4d9c-f270-43a9-a29b-f5d5c50fd08e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9c9dd21b-b9f1-45bf-a9cf-21b242750553', N'6ecd4d9c-f270-43a9-a29b-f5d5c50fd08e')

");
        }

        public override void Down()
        {
        }
    }
}
