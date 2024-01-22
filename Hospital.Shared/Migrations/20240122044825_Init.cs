using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Shared.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ROOM",
                columns: table => new
                {
                    RoomID = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    RCapacity = table.Column<int>(type: "int", nullable: false),
                    RType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROOM", x => x.RoomID);
                });

            migrationBuilder.CreateTable(
                name: "WORKER",
                columns: table => new
                {
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    WSex = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    WPhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    WFirstName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    WLastName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    WCity = table.Column<string>(type: "varchar(85)", unicode: false, maxLength: 85, nullable: true),
                    WNumber = table.Column<int>(type: "int", nullable: true),
                    WPostCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    WStreet = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKER", x => x.WorkerId);
                });

            migrationBuilder.CreateTable(
                name: "DOCTOR",
                columns: table => new
                {
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    DSpecialization = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DOCTOR__077C88265CD93F2F", x => x.WorkerId);
                    table.ForeignKey(
                        name: "FK__DOCTOR__WorkerId__286302EC",
                        column: x => x.WorkerId,
                        principalTable: "WORKER",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NURSE",
                columns: table => new
                {
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    RoomID = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NURSE__077C8826D2B144E1", x => x.WorkerId);
                    table.ForeignKey(
                        name: "FK__NURSE__RoomID__33D4B598",
                        column: x => x.RoomID,
                        principalTable: "ROOM",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK__NURSE__WorkerId__32E0915F",
                        column: x => x.WorkerId,
                        principalTable: "WORKER",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PATIENT",
                columns: table => new
                {
                    PNationalIdentificationNumber = table.Column<long>(type: "bigint", nullable: false),
                    PFirstName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    PLastName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    PEntryDate = table.Column<DateTime>(type: "date", nullable: false),
                    PBirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    PPhoneNumber = table.Column<long>(type: "bigint", nullable: true),
                    PCity = table.Column<string>(type: "varchar(85)", unicode: false, maxLength: 85, nullable: true),
                    PNumber = table.Column<int>(type: "int", nullable: true),
                    PPostCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    PStreet = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    RoomID = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    WorkerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PATIENT__280816E112055FCA", x => x.PNationalIdentificationNumber);
                    table.ForeignKey(
                        name: "FK__PATIENT__RoomID__2E1BDC42",
                        column: x => x.RoomID,
                        principalTable: "ROOM",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK__PATIENT__WorkerI__2F10007B",
                        column: x => x.WorkerId,
                        principalTable: "DOCTOR",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NURSE_RoomID",
                table: "NURSE",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_PATIENT_RoomID",
                table: "PATIENT",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_PATIENT_WorkerId",
                table: "PATIENT",
                column: "WorkerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NURSE");

            migrationBuilder.DropTable(
                name: "PATIENT");

            migrationBuilder.DropTable(
                name: "ROOM");

            migrationBuilder.DropTable(
                name: "DOCTOR");

            migrationBuilder.DropTable(
                name: "WORKER");
        }
    }
}
