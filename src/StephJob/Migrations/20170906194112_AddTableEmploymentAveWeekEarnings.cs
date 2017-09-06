using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StephJob.Migrations
{
    public partial class AddTableEmploymentAveWeekEarnings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmploymentAveWeekEarnings",
                columns: table => new
                {
                    EmploymentAveWeekEarningId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AverageWeeklyEarning2016 = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Geo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NaicsCode2Digits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Variable = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentAveWeekEarnings", x => x.EmploymentAveWeekEarningId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmploymentAveWeekEarnings");
        }
    }
}
