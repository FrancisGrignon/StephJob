using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StephJob.Migrations
{
    public partial class TableRedesignPhysicalFlowAcccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM PhysicalFlowAcccounts");

            migrationBuilder.DropColumn(
                name: "Geography",
                table: "PhysicalFlowAcccounts");

            migrationBuilder.DropColumn(
                name: "Sector",
                table: "PhysicalFlowAcccounts");

            migrationBuilder.DropColumn(
                name: "2010",
                table: "PhysicalFlowAcccounts");

            migrationBuilder.DropColumn(
                name: "2011",
                table: "PhysicalFlowAcccounts");

            migrationBuilder.DropColumn(
                name: "2012",
                table: "PhysicalFlowAcccounts");

            migrationBuilder.DropColumn(
                name: "2013",
                table: "PhysicalFlowAcccounts");

            migrationBuilder.DropColumn(
                name: "2014",
                table: "PhysicalFlowAcccounts");

            migrationBuilder.AddColumn<decimal>(
                name: "Kilotonnes",
                table: "PhysicalFlowAcccounts",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Naics",
                table: "PhysicalFlowAcccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NaicsCode2Digits",
                table: "PhysicalFlowAcccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Unknown1",
                table: "PhysicalFlowAcccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Unknown2",
                table: "PhysicalFlowAcccounts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kilotonnes",
                table: "PhysicalFlowAcccounts");

            migrationBuilder.DropColumn(
                name: "Naics",
                table: "PhysicalFlowAcccounts");

            migrationBuilder.DropColumn(
                name: "NaicsCode2Digits",
                table: "PhysicalFlowAcccounts");

            migrationBuilder.DropColumn(
                name: "Unknown1",
                table: "PhysicalFlowAcccounts");

            migrationBuilder.DropColumn(
                name: "Unknown2",
                table: "PhysicalFlowAcccounts");

            migrationBuilder.AddColumn<string>(
                name: "Geography",
                table: "PhysicalFlowAcccounts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sector",
                table: "PhysicalFlowAcccounts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "2010",
                table: "PhysicalFlowAcccounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "2011",
                table: "PhysicalFlowAcccounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "2012",
                table: "PhysicalFlowAcccounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "2013",
                table: "PhysicalFlowAcccounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "2014",
                table: "PhysicalFlowAcccounts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
