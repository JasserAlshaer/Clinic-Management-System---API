using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicManagmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LaborityTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaborityTests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 5, 10, 4, 9, 14, 126, DateTimeKind.Local).AddTicks(8898)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicien", x => x.Id);
                    table.CheckConstraint("CH_Medicien_Description", "LEN(Description) >= 8");
                    table.CheckConstraint("CH_Medicien_Name", "LEN(Name) >= 6");
                });

            migrationBuilder.CreateTable(
                name: "ProcedureTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedureTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHaveDiseases = table.Column<bool>(type: "bit", nullable: false),
                    DiesesType = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.CheckConstraint("CH_Appointment_Date", "Date >= GetDate()");
                    table.ForeignKey(
                        name: "FK_Appointments_Users_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Users_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicalReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaseType = table.Column<int>(type: "int", nullable: false),
                    MainDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalReports_Users_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicalReports_Users_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicalReports_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    PaymentMethod = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiscountType = table.Column<int>(type: "int", nullable: true),
                    DiscountAmount = table.Column<double>(type: "float", nullable: true),
                    PriceAfterDiscount = table.Column<double>(type: "float", nullable: true),
                    DiscountReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalReportId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_MedicalReports_MedicalReportId",
                        column: x => x.MedicalReportId,
                        principalTable: "MedicalReports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicalProuducres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    MedicalReportId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalProuducres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalProuducres_MedicalReports_MedicalReportId",
                        column: x => x.MedicalReportId,
                        principalTable: "MedicalReports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicalReportAttachements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementType = table.Column<int>(type: "int", nullable: false),
                    MedicalReportId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalReportAttachements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalReportAttachements_MedicalReports_MedicalReportId",
                        column: x => x.MedicalReportId,
                        principalTable: "MedicalReports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicalReportLaborities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LaborityTestId = table.Column<int>(type: "int", nullable: true),
                    MedicalReportId = table.Column<int>(type: "int", nullable: false),
                    Servity = table.Column<int>(type: "int", nullable: false),
                    TestResult = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SampleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfTests = table.Column<int>(type: "int", nullable: false),
                    TechnicianName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 5, 10, 4, 9, 14, 126, DateTimeKind.Local).AddTicks(7558)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalReportLaborities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalReportLaborities_MedicalReports_MedicalReportId",
                        column: x => x.MedicalReportId,
                        principalTable: "MedicalReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicienList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicienId = table.Column<int>(type: "int", nullable: false),
                    QTN = table.Column<int>(type: "int", nullable: false),
                    Dose = table.Column<int>(type: "int", nullable: false),
                    PerHour = table.Column<int>(type: "int", nullable: false),
                    MedicalReportId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 5, 10, 4, 9, 14, 127, DateTimeKind.Local).AddTicks(575)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicienList", x => x.Id);
                    table.CheckConstraint("CH_MedicienList_Dose", "Dose >= 3");
                    table.CheckConstraint("CH_MedicienList_PerHour", "PerHour >= 8");
                    table.CheckConstraint("CH_MedicienList_QTN", "QTN >= 1");
                    table.ForeignKey(
                        name: "FK_MedicienList_MedicalReports_MedicalReportId",
                        column: x => x.MedicalReportId,
                        principalTable: "MedicalReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SickLeaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Recommendations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalReportId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SickLeaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SickLeaves_MedicalReports_MedicalReportId",
                        column: x => x.MedicalReportId,
                        principalTable: "MedicalReports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_EmployeeId",
                table: "Appointments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_MedicalReportId",
                table: "Invoices",
                column: "MedicalReportId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalProuducres_MedicalReportId",
                table: "MedicalProuducres",
                column: "MedicalReportId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalReportAttachements_MedicalReportId",
                table: "MedicalReportAttachements",
                column: "MedicalReportId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalReportLaborities_MedicalReportId",
                table: "MedicalReportLaborities",
                column: "MedicalReportId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalReports_DoctorId",
                table: "MedicalReports",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalReports_EmployeeId",
                table: "MedicalReports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalReports_UserId",
                table: "MedicalReports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicienList_MedicalReportId",
                table: "MedicienList",
                column: "MedicalReportId");

            migrationBuilder.CreateIndex(
                name: "IX_SickLeaves_MedicalReportId",
                table: "SickLeaves",
                column: "MedicalReportId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "LaborityTests");

            migrationBuilder.DropTable(
                name: "MedicalProuducres");

            migrationBuilder.DropTable(
                name: "MedicalReportAttachements");

            migrationBuilder.DropTable(
                name: "MedicalReportLaborities");

            migrationBuilder.DropTable(
                name: "Medicien");

            migrationBuilder.DropTable(
                name: "MedicienList");

            migrationBuilder.DropTable(
                name: "ProcedureTitles");

            migrationBuilder.DropTable(
                name: "SickLeaves");

            migrationBuilder.DropTable(
                name: "MedicalReports");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
