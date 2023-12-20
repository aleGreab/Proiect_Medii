using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Mercedes.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarUserID",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarUserID",
                table: "Car",
                column: "CarUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Member_CarUserID",
                table: "Car",
                column: "CarUserID",
                principalTable: "Member",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Member_CarUserID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarUserID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CarUserID",
                table: "Car");
        }
    }
}
