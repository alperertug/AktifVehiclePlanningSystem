using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AktifVehiclePlanningSystem.Data.Migrations
{
    public partial class lastchanges : Migration
    {
        private string ManagerRoleId = Guid.NewGuid().ToString();
        private string UserRoleId = Guid.NewGuid().ToString();
        private string AdminRoleId = Guid.NewGuid().ToString();

        private string User4Id = Guid.NewGuid().ToString();
        private string User5Id = Guid.NewGuid().ToString();

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            SeedRolesSQL(migrationBuilder);

            SeedUser(migrationBuilder);

            SeedUserRoles(migrationBuilder);
        }

        private void SeedRolesSQL(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp])
            VALUES ('{AdminRoleId}', 'Administrator', 'ADMINISTRATOR', null);");
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp])
            VALUES ('{ManagerRoleId}', 'Manager', 'MANAGER', null);");
            migrationBuilder.Sql(@$"INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp])
            VALUES ('{UserRoleId}', 'User', 'USER', null);");
        }

        private void SeedUser(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @$"INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], 
                [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], 
                [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) 
                VALUES 
                (N'{User4Id}', N'Test 4', N'Lastname', N'test4@test.ca', N'TEST4@TEST.CA', 
                N'test4@test.ca', N'TEST4@TEST.CA', 0, 
                N'AQAAAAEAACcQAAAAEO54eBQ1NfAn95g9IVz47BYJ06ONZYbT3SEy5GDV2E7egUy51+pFJasPLWlm/Lk83A==', 
                N'YUPAFWNGZI2UC5FOITC7PX5J7XZTAZAA', N'8e150555-a20d-4610-93ff-49c5af44f749', NULL, 0, 0, NULL, 1, 0)");

            migrationBuilder.Sql(
            @$"INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], 
                [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], 
                [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) 
                VALUES 
                (N'{User5Id}', N'Test 5', N'Lastname', N'test5@test.ca', N'TEST5@TEST.CA', 
                N'test5@test.ca', N'TEST5@TEST.CA', 0, 
                N'AQAAAAEAACcQAAAAEO54eBQ1NfAn95g9IVz47BYJ06ONZYbT3SEy5GDV2E7egUy51+pFJasPLWlm/Lk83A==', 
                N'YUPAFWNGZI2UC5FOITC7PX5J7XZTAZAA', N'8e150555-a20d-4610-93ff-49c5af44f749', NULL, 0, 0, NULL, 1, 0)");
        }

        private void SeedUserRoles(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"
            INSERT INTO [dbo].[AspNetUserRoles]
                ([UserId]
                ,[RoleId])
                VALUES
                ('{User4Id}', '{ManagerRoleId}');
            INSERT INTO [dbo].[AspNetUserRoles]
                ([UserId]
                ,[RoleId])
                VALUES
                ('{User4Id}', '{UserRoleId}');");

            migrationBuilder.Sql(@$"
            INSERT INTO [dbo].[AspNetUserRoles]
                ([UserId]
                ,[RoleId])
                VALUES
                ('{User5Id}', '{AdminRoleId}');
            INSERT INTO [dbo].[AspNetUserRoles]
                ([UserId]
                ,[RoleId])
                VALUES
                ('{User5Id}', '{ManagerRoleId}');");

        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
