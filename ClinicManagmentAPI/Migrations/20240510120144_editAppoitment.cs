using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicManagmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class editAppoitment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "MedicienList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 10, 15, 1, 44, 137, DateTimeKind.Local).AddTicks(8574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 10, 4, 9, 14, 127, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Medicien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 10, 15, 1, 44, 137, DateTimeKind.Local).AddTicks(6185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 10, 4, 9, 14, 126, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "MedicalReportLaborities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 10, 15, 1, 44, 137, DateTimeKind.Local).AddTicks(4382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 10, 4, 9, 14, 126, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Appointments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "MedicienList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 10, 4, 9, 14, 127, DateTimeKind.Local).AddTicks(575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 10, 15, 1, 44, 137, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Medicien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 10, 4, 9, 14, 126, DateTimeKind.Local).AddTicks(8898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 10, 15, 1, 44, 137, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "MedicalReportLaborities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 10, 4, 9, 14, 126, DateTimeKind.Local).AddTicks(7558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 10, 15, 1, 44, 137, DateTimeKind.Local).AddTicks(4382));
        }
    }
}
