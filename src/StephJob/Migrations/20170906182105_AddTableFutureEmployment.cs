using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StephJob.Migrations
{
    public partial class AddTableFutureEmployment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FutureEmployments",
                columns: table => new
                {
                    FutureEmploymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Probability = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    SocCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FutureEmployments", x => x.FutureEmploymentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FutureEmployments");
        }
    }
}
