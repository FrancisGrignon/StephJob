using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StephJob.Migrations
{
    public partial class AddTableUnemploymentJobVacanciesRatios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnemploymentJobVacanciesRatios",
                columns: table => new
                {
                    UnemploymentJobVacanciesRatioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Geography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NaicsCode2Digits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _2016 = table.Column<decimal>(name: "2016", type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnemploymentJobVacanciesRatios", x => x.UnemploymentJobVacanciesRatioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnemploymentJobVacanciesRatios");
        }
    }
}
