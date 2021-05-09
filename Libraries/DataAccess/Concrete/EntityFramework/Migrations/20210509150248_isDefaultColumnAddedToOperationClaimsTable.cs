using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Concrete.EntityFramework.Migrations
{
    public partial class isDefaultColumnAddedToOperationClaimsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "OperationClaims",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "OperationClaims");
        }
    }
}
