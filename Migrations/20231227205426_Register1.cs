using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Mercedes.Migrations
{
    /// <inheritdoc />
    public partial class Register1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Model_ModelID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Motorization_MotorID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_State_StateID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Transmission_TransmissionID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_ModelID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_MotorID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_StateID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_TransmissionID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "ModelID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "MotorID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "StateID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "TransmissionID",
                table: "Car");

            migrationBuilder.AlterColumn<int>(
                name: "CarTransID",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarStateID",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarMotorID",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarModelID",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarModelID",
                table: "Car",
                column: "CarModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarMotorID",
                table: "Car",
                column: "CarMotorID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarStateID",
                table: "Car",
                column: "CarStateID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarTransID",
                table: "Car",
                column: "CarTransID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Model_CarModelID",
                table: "Car",
                column: "CarModelID",
                principalTable: "Model",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Motorization_CarMotorID",
                table: "Car",
                column: "CarMotorID",
                principalTable: "Motorization",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_State_CarStateID",
                table: "Car",
                column: "CarStateID",
                principalTable: "State",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Transmission_CarTransID",
                table: "Car",
                column: "CarTransID",
                principalTable: "Transmission",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Model_CarModelID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Motorization_CarMotorID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_State_CarStateID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Transmission_CarTransID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarModelID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarMotorID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarStateID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarTransID",
                table: "Car");

            migrationBuilder.AlterColumn<int>(
                name: "CarTransID",
                table: "Car",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CarStateID",
                table: "Car",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CarMotorID",
                table: "Car",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CarModelID",
                table: "Car",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ModelID",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotorID",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StateID",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransmissionID",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Car_ModelID",
                table: "Car",
                column: "ModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_MotorID",
                table: "Car",
                column: "MotorID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_StateID",
                table: "Car",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_TransmissionID",
                table: "Car",
                column: "TransmissionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Model_ModelID",
                table: "Car",
                column: "ModelID",
                principalTable: "Model",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Motorization_MotorID",
                table: "Car",
                column: "MotorID",
                principalTable: "Motorization",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_State_StateID",
                table: "Car",
                column: "StateID",
                principalTable: "State",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Transmission_TransmissionID",
                table: "Car",
                column: "TransmissionID",
                principalTable: "Transmission",
                principalColumn: "ID");
        }
    }
}
