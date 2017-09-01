using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StephJob.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sdgs372s",
                columns: table => new
                {
                    Sdgs372Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrAreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goal = table.Column<int>(type: "int", nullable: false),
                    IndicatorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LDC = table.Column<bool>(type: "bit", nullable: true),
                    LLDC = table.Column<bool>(type: "bit", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCountryOrAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIDS = table.Column<bool>(type: "bit", nullable: true),
                    SeriesCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitMultiplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2000 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2000FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2001 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2001FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2002 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2002FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2003 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2003FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2004 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2004FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2005 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2005FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2006 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2006FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2007 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2007FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2008 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2008FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2009 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2009FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2010 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2010FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2011 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2011FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2012 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2012FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2013 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2013FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2014 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2014FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2015 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2015FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2016 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2016FN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sdgs372s", x => x.Sdgs372Id);
                });

            migrationBuilder.CreateTable(
                name: "Sdgs411s",
                columns: table => new
                {
                    Sdgs411Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrAreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goal = table.Column<int>(type: "int", nullable: false),
                    IndicatorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LDC = table.Column<bool>(type: "bit", nullable: true),
                    LLDC = table.Column<bool>(type: "bit", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCountryOrAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIDS = table.Column<bool>(type: "bit", nullable: true),
                    SeriesCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitMultiplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2000 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2000FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2001 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2001FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2002 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2002FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2003 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2003FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2004 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2004FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2005 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2005FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2006 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2006FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2007 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2007FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2008 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2008FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2009 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2009FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2010 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2010FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2011 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2011FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2012 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2012FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2013 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2013FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2014 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2014FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2015 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2015FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2016 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2016FN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sdgs411s", x => x.Sdgs411Id);
                });

            migrationBuilder.CreateTable(
                name: "Sdgs431s",
                columns: table => new
                {
                    Sdgs431Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrAreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goal = table.Column<int>(type: "int", nullable: false),
                    IndicatorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LDC = table.Column<bool>(type: "bit", nullable: true),
                    LLDC = table.Column<bool>(type: "bit", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCountryOrAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIDS = table.Column<bool>(type: "bit", nullable: true),
                    SeriesCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitMultiplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2000 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2000FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2001 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2001FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2002 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2002FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2003 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2003FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2004 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2004FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2005 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2005FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2006 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2006FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2007 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2007FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2008 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2008FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2009 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2009FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2010 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2010FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2011 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2011FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2012 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2012FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2013 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2013FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2014 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2014FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2015 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2015FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2016 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2016FN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sdgs431s", x => x.Sdgs431Id);
                });

            migrationBuilder.CreateTable(
                name: "Sdgs441s",
                columns: table => new
                {
                    Sdgs441Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrAreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goal = table.Column<int>(type: "int", nullable: false),
                    IndicatorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LDC = table.Column<bool>(type: "bit", nullable: true),
                    LLDC = table.Column<bool>(type: "bit", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCountryOrAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIDS = table.Column<bool>(type: "bit", nullable: true),
                    SeriesCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitMultiplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2000 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2000FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2001 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2001FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2002 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2002FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2003 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2003FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2004 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2004FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2005 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2005FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2006 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2006FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2007 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2007FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2008 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2008FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2009 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2009FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2010 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2010FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2011 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2011FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2012 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2012FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2013 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2013FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2014 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2014FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2015 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2015FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2016 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2016FN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sdgs441s", x => x.Sdgs441Id);
                });

            migrationBuilder.CreateTable(
                name: "Sdgs531s",
                columns: table => new
                {
                    Sdgs531Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrAreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goal = table.Column<int>(type: "int", nullable: false),
                    IndicatorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LDC = table.Column<bool>(type: "bit", nullable: true),
                    LLDC = table.Column<bool>(type: "bit", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCountryOrAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIDS = table.Column<bool>(type: "bit", nullable: true),
                    SeriesCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitMultiplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2000 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2000FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2001 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2001FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2002 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2002FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2003 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2003FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2004 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2004FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2005 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2005FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2006 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2006FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2007 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2007FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2008 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2008FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2009 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2009FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2010 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2010FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2011 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2011FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2012 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2012FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2013 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2013FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2014 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2014FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2015 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2015FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2016 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2016FN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sdgs531s", x => x.Sdgs531Id);
                });

            migrationBuilder.CreateTable(
                name: "Sdgs861s",
                columns: table => new
                {
                    Sdgs861Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrAreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goal = table.Column<int>(type: "int", nullable: false),
                    IndicatorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndicatorRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LDC = table.Column<bool>(type: "bit", nullable: true),
                    LLDC = table.Column<bool>(type: "bit", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCountryOrAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIDS = table.Column<bool>(type: "bit", nullable: true),
                    SeriesCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitMultiplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2000 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2000FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2001 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2001FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2002 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2002FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2003 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2003FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2004 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2004FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2005 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2005FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2006 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2006FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2007 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2007FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2008 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2008FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2009 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2009FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2010 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2010FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2011 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2011FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2012 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2012FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2013 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2013FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2014 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2014FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2015 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2015FN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Y2016 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Y2016FN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sdgs861s", x => x.Sdgs861Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sdgs372s");

            migrationBuilder.DropTable(
                name: "Sdgs411s");

            migrationBuilder.DropTable(
                name: "Sdgs431s");

            migrationBuilder.DropTable(
                name: "Sdgs441s");

            migrationBuilder.DropTable(
                name: "Sdgs531s");

            migrationBuilder.DropTable(
                name: "Sdgs861s");
        }
    }
}
