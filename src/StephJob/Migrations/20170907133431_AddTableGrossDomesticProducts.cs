using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StephJob.Migrations
{
    public partial class AddTableGrossDomesticProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GrossDomesticProducts",
                columns: table => new
                {
                    GrossDomesticProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Geography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NaicsCode2Digits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prices = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeasonalAdjustment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _1997 = table.Column<int>(name: "1997", type: "int", nullable: false),
                    _1998 = table.Column<int>(name: "1998", type: "int", nullable: false),
                    _1999 = table.Column<int>(name: "1999", type: "int", nullable: false),
                    _2000 = table.Column<int>(name: "2000", type: "int", nullable: false),
                    _2001 = table.Column<int>(name: "2001", type: "int", nullable: false),
                    _2002 = table.Column<int>(name: "2002", type: "int", nullable: false),
                    _2003 = table.Column<int>(name: "2003", type: "int", nullable: false),
                    _2004 = table.Column<int>(name: "2004", type: "int", nullable: false),
                    _2005 = table.Column<int>(name: "2005", type: "int", nullable: false),
                    _2006 = table.Column<int>(name: "2006", type: "int", nullable: false),
                    _2007 = table.Column<int>(name: "2007", type: "int", nullable: false),
                    _2008 = table.Column<int>(name: "2008", type: "int", nullable: false),
                    _2009 = table.Column<int>(name: "2009", type: "int", nullable: false),
                    _2010 = table.Column<int>(name: "2010", type: "int", nullable: false),
                    _2011 = table.Column<int>(name: "2011", type: "int", nullable: false),
                    _2012 = table.Column<int>(name: "2012", type: "int", nullable: false),
                    _2013 = table.Column<int>(name: "2013", type: "int", nullable: false),
                    _2014 = table.Column<int>(name: "2014", type: "int", nullable: false),
                    _2015 = table.Column<int>(name: "2015", type: "int", nullable: false),
                    _2016 = table.Column<int>(name: "2016", type: "int", nullable: false),
                    _2017 = table.Column<int>(name: "2017", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrossDomesticProducts", x => x.GrossDomesticProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrossDomesticProducts");
        }
    }
}
