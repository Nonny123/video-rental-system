namespace VRSWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'65d08233-7259-4919-baea-e84bf1dac063', N'guestuser@vrs.com', 0, N'AKxJobltbrf+sj7ihf6X3N43WgLsa2zLHR1LHyHg+vvq/3Rw5jDgovpecQ7FgYSdEg==', N'9ac69722-47e5-4ec9-9680-747f73f04d54', NULL, 0, 0, NULL, 1, 0, N'guestuser@vrs.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8fde19e6-d6e3-43d6-916b-00c29b42bcee', N'storeadmin@vrs.com', 0, N'AB9gtGMUgwxjknrHI3SJkwCc7NzazyJySbSb9lS5Fyvvxmw6JwUsfzPLpi20V/BdXg==', N'5cfc10ed-53e4-4fd2-9c14-17491d1fa49c', NULL, 0, 0, NULL, 1, 0, N'storeadmin@vrs.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2c788049-d934-4ad5-85fe-1a191fa4cd01', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8fde19e6-d6e3-43d6-916b-00c29b42bcee', N'2c788049-d934-4ad5-85fe-1a191fa4cd01')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
