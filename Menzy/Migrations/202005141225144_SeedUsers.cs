namespace Menzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'17df1a27-3ebb-4c8e-a1f1-1cd097fbdc8b', N'admin@menzy.com', 0, N'APtbobtcVdhhdCMjd+1JXSSO+wZF2aXpjn0eT2K5nOFho5cSN9qjP7+MhpyNeS5EIA==', N'0250e955-0b61-440c-be9a-87e4d6ad2a41', NULL, 0, 0, NULL, 1, 0, N'admin@menzy.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'422be637-ad0e-4e2b-bff8-7b5af8f4e2e5', N'jojojo2810@gmail.com', 0, N'ALwNLKjMTwtFIEe1eqbby2Vsc0s1vdohQCaLk8AV6yv5fim33xnbNtkxnRTKgyt2Pg==', N'db6d295a-0e8b-4d66-a35c-630863aacffe', NULL, 0, 0, NULL, 1, 0, N'jojojo2810@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f4f39d52-c387-4d7f-b737-985cd137c318', N'guest@menzy.com', 0, N'APZZVPdJcRC/l2pSopPq235mIUlg+gT4dHoqFuQeLPLSUgY8qvhhIhT/wmxcZhuTDQ==', N'83f4c17c-cfee-436b-9327-c11e2342ba6a', NULL, 0, 0, NULL, 1, 0, N'guest@menzy.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bab92b5d-ce58-4604-a1b0-6bc946474016', N'CanManageFoods')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'17df1a27-3ebb-4c8e-a1f1-1cd097fbdc8b', N'bab92b5d-ce58-4604-a1b0-6bc946474016')


");
        }
        
        public override void Down()
        {
        }
    }
}
