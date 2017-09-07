using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StephJob.Migrations
{
    public partial class AddTablePhysicalFlowAcccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhysicalFlowAcccounts",
                columns: table => new
                {
                    PhysicalFlowAcccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Geography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _2010 = table.Column<int>(name: "2010", type: "int", nullable: false),
                    _2011 = table.Column<int>(name: "2011", type: "int", nullable: false),
                    _2012 = table.Column<int>(name: "2012", type: "int", nullable: false),
                    _2013 = table.Column<int>(name: "2013", type: "int", nullable: false),
                    _2014 = table.Column<int>(name: "2014", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalFlowAcccounts", x => x.PhysicalFlowAcccountId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhysicalFlowAcccounts");
        }
    }
}
