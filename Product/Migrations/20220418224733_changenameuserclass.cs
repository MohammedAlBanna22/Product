using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.Migrations
{
    public partial class changenameuserclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "appUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appUsers",
                table: "appUsers",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_appUsers",
                table: "appUsers");

            migrationBuilder.RenameTable(
                name: "appUsers",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "id");
        }
    }
}
