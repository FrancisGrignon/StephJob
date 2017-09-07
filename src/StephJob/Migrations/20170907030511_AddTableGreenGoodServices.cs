using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StephJob.Migrations
{
    public partial class AddTableGreenGoodServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GreenGoodServices",
                columns: table => new
                {
                    GreenGoodServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GgsEmployment = table.Column<int>(type: "int", nullable: false),
                    GgsPercent = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NaicsCode2Digit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalEmployment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GreenGoodServices", x => x.GreenGoodServiceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GreenGoodServices");
        }
    }
}
