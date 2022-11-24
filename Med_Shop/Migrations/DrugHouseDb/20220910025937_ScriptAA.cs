using Microsoft.EntityFrameworkCore.Migrations;

namespace Med_Shop.Migrations.DrugHouseDb
{
    public partial class ScriptAA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Medicine_MedicineID",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_MedicineID",
                table: "Bill");

            migrationBuilder.AlterColumn<string>(
                name: "MedicineID",
                table: "Bill",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MedicineID1",
                table: "Bill",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bill_MedicineID1",
                table: "Bill",
                column: "MedicineID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Medicine_MedicineID1",
                table: "Bill",
                column: "MedicineID1",
                principalTable: "Medicine",
                principalColumn: "MedicineID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Medicine_MedicineID1",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_MedicineID1",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "MedicineID1",
                table: "Bill");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineID",
                table: "Bill",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bill_MedicineID",
                table: "Bill",
                column: "MedicineID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Medicine_MedicineID",
                table: "Bill",
                column: "MedicineID",
                principalTable: "Medicine",
                principalColumn: "MedicineID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
