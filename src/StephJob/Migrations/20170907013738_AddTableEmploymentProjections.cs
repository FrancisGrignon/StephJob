using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StephJob.Migrations
{
    public partial class AddTableEmploymentProjections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmploymentProjections",
                columns: table => new
                {
                    EmploymentProjectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NocCode = table.Column<int>(type: "int", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _2014 = table.Column<int>(name: "2014", type: "int", nullable: false),
                    _2015 = table.Column<int>(name: "2015", type: "int", nullable: false),
                    _2016 = table.Column<int>(name: "2016", type: "int", nullable: false),
                    _2017 = table.Column<int>(name: "2017", type: "int", nullable: false),
                    _2018 = table.Column<int>(name: "2018", type: "int", nullable: false),
                    _2019 = table.Column<int>(name: "2019", type: "int", nullable: false),
                    _2020 = table.Column<int>(name: "2020", type: "int", nullable: false),
                    _2021 = table.Column<int>(name: "2021", type: "int", nullable: false),
                    _2022 = table.Column<int>(name: "2022", type: "int", nullable: false),
                    _2023 = table.Column<int>(name: "2023", type: "int", nullable: false),
                    _2024 = table.Column<int>(name: "2024", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentProjections", x => x.EmploymentProjectionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmploymentProjections");
        }
    }
}
