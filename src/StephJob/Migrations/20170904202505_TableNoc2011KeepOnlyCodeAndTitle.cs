using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StephJob.Migrations
{
    public partial class TableNoc2011KeepOnlyCodeAndTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Noc2011s");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Noc2011s");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Noc2011s");

            migrationBuilder.DropColumn(
                name: "TypeLabel",
                table: "Noc2011s");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Noc2011s",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Noc2011s");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Noc2011s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Noc2011s",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TypeLabel",
                table: "Noc2011s",
                nullable: true);
        }
    }
}
