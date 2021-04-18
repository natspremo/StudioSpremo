using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudioSpremoBack.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobsFlexo",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    Service = table.Column<int>(nullable: false),
                    RadniNalog = table.Column<string>(nullable: true),
                    JobName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Liniature = table.Column<int>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false),
                    OverprintBlack = table.Column<bool>(nullable: false),
                    Prepress = table.Column<bool>(nullable: false),
                    CourierIncluded = table.Column<bool>(nullable: false),
                    PolymerThicknessId = table.Column<string>(nullable: true),
                    OrderedTime = table.Column<DateTime>(nullable: false),
                    MaterialType = table.Column<string>(nullable: true),
                    Montage = table.Column<bool>(nullable: false),
                    ObimValjka = table.Column<int>(nullable: false),
                    RollWidth = table.Column<double>(nullable: false),
                    SeparationSum = table.Column<int>(nullable: false),
                    FileShortening = table.Column<bool>(nullable: false),
                    BrOtpremnice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobsFlexo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobsFlexo_PolymerThicknesses_PolymerThicknessId",
                        column: x => x.PolymerThicknessId,
                        principalTable: "PolymerThicknesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobsOffset",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    Service = table.Column<int>(nullable: false),
                    OrderedTime = table.Column<DateTime>(nullable: false),
                    RadniNalog = table.Column<string>(nullable: true),
                    JobName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Liniature = table.Column<int>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false),
                    OverprintBlack = table.Column<bool>(nullable: false),
                    Prepress = table.Column<bool>(nullable: false),
                    CourierIncluded = table.Column<bool>(nullable: false),
                    PlateDimensionId = table.Column<string>(nullable: true),
                    PlateSum = table.Column<int>(nullable: false),
                    BrOtpremnice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobsOffset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobsOffset_PlateDimensions_PlateDimensionId",
                        column: x => x.PlateDimensionId,
                        principalTable: "PlateDimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilesFlexo",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    JobId = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesFlexo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilesFlexo_JobsFlexo_JobId",
                        column: x => x.JobId,
                        principalTable: "JobsFlexo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilesOffset",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    JobId = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesOffset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilesOffset_JobsOffset_JobId",
                        column: x => x.JobId,
                        principalTable: "JobsOffset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilesFlexo_JobId",
                table: "FilesFlexo",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_FilesOffset_JobId",
                table: "FilesOffset",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobsFlexo_PolymerThicknessId",
                table: "JobsFlexo",
                column: "PolymerThicknessId");

            migrationBuilder.CreateIndex(
                name: "IX_JobsOffset_PlateDimensionId",
                table: "JobsOffset",
                column: "PlateDimensionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilesFlexo");

            migrationBuilder.DropTable(
                name: "FilesOffset");

            migrationBuilder.DropTable(
                name: "JobsFlexo");

            migrationBuilder.DropTable(
                name: "JobsOffset");
        }
    }
}
