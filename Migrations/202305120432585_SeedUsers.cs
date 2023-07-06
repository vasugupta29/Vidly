namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'826a23a7-07d5-48a4-8eba-f0762d484f3c', N'guest@vidly.com', 0, N'APMbHp4BtZPVbjl1DfuLkp1/FStK6fqGcJyTa1cHPqBCaOBkEbGS0j/3pAj00abVKQ==', N'db64ccfe-8a8d-4771-be8e-b48a42ac694e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a868f5ff-ffdd-4d2e-8251-cc77c4d85e5f', N'admin@vidly.com', 0, N'ABhQW53NN66WKonNOMFg/lMPFkFKctPr7eSaJvb4sboPDISlMo9zUZquLbnMm/GAzw==', N'1db1a16c-a12e-4f61-9c17-c47692002c26', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e9582842-4941-4ed1-ac8c-c3f7fc9d2e65', N'canManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a868f5ff-ffdd-4d2e-8251-cc77c4d85e5f', N'e9582842-4941-4ed1-ac8c-c3f7fc9d2e65')

");
        }
        
        public override void Down()
        {
        }
    }
}
