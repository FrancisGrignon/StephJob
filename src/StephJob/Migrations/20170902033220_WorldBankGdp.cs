using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StephJob.Migrations
{
    public partial class WorldBankGdp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorldBankGdps",
                columns: table => new
                {
                    WorldBankGdpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y1960 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1961 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1962 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1963 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1964 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1965 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1966 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1967 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1968 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1969 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1970 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1971 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1972 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1973 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1974 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1975 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1976 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1977 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1978 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1979 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1980 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1981 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1982 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1983 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1984 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1985 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1986 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1987 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1988 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1989 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1990 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1991 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1992 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1993 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1994 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1995 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1996 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1997 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1998 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y1999 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2000 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2001 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2002 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2003 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2004 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2005 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2006 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2007 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2008 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2009 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2010 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2011 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2012 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2013 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2014 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2015 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2016 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorldBankGdps", x => x.WorldBankGdpId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorldBankGdps");
        }
    }
}
