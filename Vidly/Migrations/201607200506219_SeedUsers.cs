namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'36e275b3-b756-405f-9ae9-b92da39f16d0', N'guest@vidly.com', 0, N'ALF8pmaD17dyfXHCsiTMRtJSgfcc2B4OK27uT0S1Q1cZbp9CiMng2/dqZ4Yuu3qa1Q==', N'84ab0d5e-be4f-4056-9a80-0ff742e81d15', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'685305e0-f24b-43c9-bae2-c20f214176be', N'admin1@vidly.com', 0, N'AJsq9zdbHsJs9iAJsBdjFTCSVpIwvPCSHQhO3MzAoqjJ9UT4w7kJucxhBbsgaVo1Jw==', N'0b00d73c-0e5d-400d-b2f6-c49127250d5a', NULL, 0, 0, NULL, 1, 0, N'admin1@vidly.com')
            
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2ed76496-3628-49d1-95f7-f4dda3595536', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'685305e0-f24b-43c9-bae2-c20f214176be', N'2ed76496-3628-49d1-95f7-f4dda3595536')

");
        }
        
        public override void Down()
        {
        }
    }
}
