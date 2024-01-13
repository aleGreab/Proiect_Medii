using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Mercedes.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CarCategoryID",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarCategoryID",
                table: "Car",
                column: "CarCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Category_CarCategoryID",
                table: "Car",
                column: "CarCategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Category_CarCategoryID",
                table: "Car");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarCategoryID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CarCategoryID",
                table: "Car");

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
    }
}
