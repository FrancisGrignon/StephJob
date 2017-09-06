﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using StephJob.Persistance;
using System;

namespace StephJob.Migrations
{
    [DbContext(typeof(StephContext))]
    partial class StephContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StephJob.Core.Domain.FutureEmployment", b =>
                {
                    b.Property<int>("FutureEmploymentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Occupation");

                    b.Property<decimal>("Probability");

                    b.Property<int>("Rank");

                    b.Property<string>("SocCode");

                    b.HasKey("FutureEmploymentId");

                    b.ToTable("FutureEmployments");
                });

            modelBuilder.Entity("StephJob.Core.Domain.Naics", b =>
                {
                    b.Property<int>("NaicsId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Code");

                    b.Property<string>("Definition");

                    b.Property<string>("Hierarchical");

                    b.Property<int>("Level");

                    b.Property<string>("Superscript");

                    b.Property<string>("Title");

                    b.HasKey("NaicsId");

                    b.ToTable("Naics");
                });

            modelBuilder.Entity("StephJob.Core.Domain.Noc2011", b =>
                {
                    b.Property<int>("Noc2011Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Code");

                    b.Property<string>("Title");

                    b.HasKey("Noc2011Id");

                    b.ToTable("Noc2011s");
                });

            modelBuilder.Entity("StephJob.Core.Domain.Sdgs372", b =>
                {
                    b.Property<int>("Sdgs372Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AgeGroup");

                    b.Property<string>("CountryOrAreaCode");

                    b.Property<string>("CountryOrAreaName");

                    b.Property<string>("Frequency");

                    b.Property<int>("Goal");

                    b.Property<string>("IndicatorDescription");

                    b.Property<string>("IndicatorId");

                    b.Property<string>("IndicatorRef");

                    b.Property<bool?>("LDC");

                    b.Property<bool?>("LLDC");

                    b.Property<string>("Location");

                    b.Property<string>("ParentCountryOrAreaCode");

                    b.Property<bool?>("SIDS");

                    b.Property<string>("SeriesCode");

                    b.Property<string>("SeriesDescription");

                    b.Property<string>("SeriesType");

                    b.Property<string>("Sex");

                    b.Property<string>("SourceType");

                    b.Property<string>("Target");

                    b.Property<string>("Unit");

                    b.Property<string>("UnitMultiplier");

                    b.Property<string>("ValueType");

                    b.Property<string>("Y2000");

                    b.Property<string>("Y2000FN");

                    b.Property<decimal?>("Y2001");

                    b.Property<string>("Y2001FN");

                    b.Property<decimal?>("Y2002");

                    b.Property<string>("Y2002FN");

                    b.Property<decimal?>("Y2003");

                    b.Property<string>("Y2003FN");

                    b.Property<decimal?>("Y2004");

                    b.Property<string>("Y2004FN");

                    b.Property<decimal?>("Y2005");

                    b.Property<string>("Y2005FN");

                    b.Property<decimal?>("Y2006");

                    b.Property<string>("Y2006FN");

                    b.Property<decimal?>("Y2007");

                    b.Property<string>("Y2007FN");

                    b.Property<decimal?>("Y2008");

                    b.Property<string>("Y2008FN");

                    b.Property<decimal?>("Y2009");

                    b.Property<string>("Y2009FN");

                    b.Property<decimal?>("Y2010");

                    b.Property<string>("Y2010FN");

                    b.Property<decimal?>("Y2011");

                    b.Property<string>("Y2011FN");

                    b.Property<decimal?>("Y2012");

                    b.Property<string>("Y2012FN");

                    b.Property<decimal?>("Y2013");

                    b.Property<string>("Y2013FN");

                    b.Property<decimal?>("Y2014");

                    b.Property<string>("Y2014FN");

                    b.Property<decimal?>("Y2015");

                    b.Property<string>("Y2015FN");

                    b.Property<decimal?>("Y2016");

                    b.Property<string>("Y2016FN");

                    b.HasKey("Sdgs372Id");

                    b.ToTable("Sdgs372s");
                });

            modelBuilder.Entity("StephJob.Core.Domain.Sdgs411", b =>
                {
                    b.Property<int>("Sdgs411Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AgeGroup");

                    b.Property<string>("CountryOrAreaCode");

                    b.Property<string>("CountryOrAreaName");

                    b.Property<string>("Frequency");

                    b.Property<int>("Goal");

                    b.Property<string>("IndicatorDescription");

                    b.Property<string>("IndicatorId");

                    b.Property<string>("IndicatorRef");

                    b.Property<bool?>("LDC");

                    b.Property<bool?>("LLDC");

                    b.Property<string>("Location");

                    b.Property<string>("ParentCountryOrAreaCode");

                    b.Property<bool?>("SIDS");

                    b.Property<string>("SeriesCode");

                    b.Property<string>("SeriesDescription");

                    b.Property<string>("SeriesType");

                    b.Property<string>("Sex");

                    b.Property<string>("SourceType");

                    b.Property<string>("Target");

                    b.Property<string>("Unit");

                    b.Property<string>("UnitMultiplier");

                    b.Property<string>("ValueType");

                    b.Property<string>("Y2000");

                    b.Property<string>("Y2000FN");

                    b.Property<decimal?>("Y2001");

                    b.Property<string>("Y2001FN");

                    b.Property<decimal?>("Y2002");

                    b.Property<string>("Y2002FN");

                    b.Property<decimal?>("Y2003");

                    b.Property<string>("Y2003FN");

                    b.Property<decimal?>("Y2004");

                    b.Property<string>("Y2004FN");

                    b.Property<decimal?>("Y2005");

                    b.Property<string>("Y2005FN");

                    b.Property<decimal?>("Y2006");

                    b.Property<string>("Y2006FN");

                    b.Property<decimal?>("Y2007");

                    b.Property<string>("Y2007FN");

                    b.Property<decimal?>("Y2008");

                    b.Property<string>("Y2008FN");

                    b.Property<decimal?>("Y2009");

                    b.Property<string>("Y2009FN");

                    b.Property<decimal?>("Y2010");

                    b.Property<string>("Y2010FN");

                    b.Property<decimal?>("Y2011");

                    b.Property<string>("Y2011FN");

                    b.Property<decimal?>("Y2012");

                    b.Property<string>("Y2012FN");

                    b.Property<decimal?>("Y2013");

                    b.Property<string>("Y2013FN");

                    b.Property<decimal?>("Y2014");

                    b.Property<string>("Y2014FN");

                    b.Property<decimal?>("Y2015");

                    b.Property<string>("Y2015FN");

                    b.Property<decimal?>("Y2016");

                    b.Property<string>("Y2016FN");

                    b.HasKey("Sdgs411Id");

                    b.ToTable("Sdgs411s");
                });

            modelBuilder.Entity("StephJob.Core.Domain.Sdgs431", b =>
                {
                    b.Property<int>("Sdgs431Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AgeGroup");

                    b.Property<string>("CountryOrAreaCode");

                    b.Property<string>("CountryOrAreaName");

                    b.Property<string>("Frequency");

                    b.Property<int>("Goal");

                    b.Property<string>("IndicatorDescription");

                    b.Property<string>("IndicatorId");

                    b.Property<string>("IndicatorRef");

                    b.Property<bool?>("LDC");

                    b.Property<bool?>("LLDC");

                    b.Property<string>("Location");

                    b.Property<string>("ParentCountryOrAreaCode");

                    b.Property<bool?>("SIDS");

                    b.Property<string>("SeriesCode");

                    b.Property<string>("SeriesDescription");

                    b.Property<string>("SeriesType");

                    b.Property<string>("Sex");

                    b.Property<string>("SourceType");

                    b.Property<string>("Target");

                    b.Property<string>("Unit");

                    b.Property<string>("UnitMultiplier");

                    b.Property<string>("ValueType");

                    b.Property<string>("Y2000");

                    b.Property<string>("Y2000FN");

                    b.Property<decimal?>("Y2001");

                    b.Property<string>("Y2001FN");

                    b.Property<decimal?>("Y2002");

                    b.Property<string>("Y2002FN");

                    b.Property<decimal?>("Y2003");

                    b.Property<string>("Y2003FN");

                    b.Property<decimal?>("Y2004");

                    b.Property<string>("Y2004FN");

                    b.Property<decimal?>("Y2005");

                    b.Property<string>("Y2005FN");

                    b.Property<decimal?>("Y2006");

                    b.Property<string>("Y2006FN");

                    b.Property<decimal?>("Y2007");

                    b.Property<string>("Y2007FN");

                    b.Property<decimal?>("Y2008");

                    b.Property<string>("Y2008FN");

                    b.Property<decimal?>("Y2009");

                    b.Property<string>("Y2009FN");

                    b.Property<decimal?>("Y2010");

                    b.Property<string>("Y2010FN");

                    b.Property<decimal?>("Y2011");

                    b.Property<string>("Y2011FN");

                    b.Property<decimal?>("Y2012");

                    b.Property<string>("Y2012FN");

                    b.Property<decimal?>("Y2013");

                    b.Property<string>("Y2013FN");

                    b.Property<decimal?>("Y2014");

                    b.Property<string>("Y2014FN");

                    b.Property<decimal?>("Y2015");

                    b.Property<string>("Y2015FN");

                    b.Property<decimal?>("Y2016");

                    b.Property<string>("Y2016FN");

                    b.HasKey("Sdgs431Id");

                    b.ToTable("Sdgs431s");
                });

            modelBuilder.Entity("StephJob.Core.Domain.Sdgs441", b =>
                {
                    b.Property<int>("Sdgs441Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AgeGroup");

                    b.Property<string>("CountryOrAreaCode");

                    b.Property<string>("CountryOrAreaName");

                    b.Property<string>("Frequency");

                    b.Property<int>("Goal");

                    b.Property<string>("IndicatorDescription");

                    b.Property<string>("IndicatorId");

                    b.Property<string>("IndicatorRef");

                    b.Property<bool?>("LDC");

                    b.Property<bool?>("LLDC");

                    b.Property<string>("Location");

                    b.Property<string>("ParentCountryOrAreaCode");

                    b.Property<bool?>("SIDS");

                    b.Property<string>("SeriesCode");

                    b.Property<string>("SeriesDescription");

                    b.Property<string>("SeriesType");

                    b.Property<string>("Sex");

                    b.Property<string>("SourceType");

                    b.Property<string>("Target");

                    b.Property<string>("Unit");

                    b.Property<string>("UnitMultiplier");

                    b.Property<string>("ValueType");

                    b.Property<string>("Y2000");

                    b.Property<string>("Y2000FN");

                    b.Property<decimal?>("Y2001");

                    b.Property<string>("Y2001FN");

                    b.Property<decimal?>("Y2002");

                    b.Property<string>("Y2002FN");

                    b.Property<decimal?>("Y2003");

                    b.Property<string>("Y2003FN");

                    b.Property<decimal?>("Y2004");

                    b.Property<string>("Y2004FN");

                    b.Property<decimal?>("Y2005");

                    b.Property<string>("Y2005FN");

                    b.Property<decimal?>("Y2006");

                    b.Property<string>("Y2006FN");

                    b.Property<decimal?>("Y2007");

                    b.Property<string>("Y2007FN");

                    b.Property<decimal?>("Y2008");

                    b.Property<string>("Y2008FN");

                    b.Property<decimal?>("Y2009");

                    b.Property<string>("Y2009FN");

                    b.Property<decimal?>("Y2010");

                    b.Property<string>("Y2010FN");

                    b.Property<decimal?>("Y2011");

                    b.Property<string>("Y2011FN");

                    b.Property<decimal?>("Y2012");

                    b.Property<string>("Y2012FN");

                    b.Property<decimal?>("Y2013");

                    b.Property<string>("Y2013FN");

                    b.Property<decimal?>("Y2014");

                    b.Property<string>("Y2014FN");

                    b.Property<decimal?>("Y2015");

                    b.Property<string>("Y2015FN");

                    b.Property<decimal?>("Y2016");

                    b.Property<string>("Y2016FN");

                    b.HasKey("Sdgs441Id");

                    b.ToTable("Sdgs441s");
                });

            modelBuilder.Entity("StephJob.Core.Domain.Sdgs531", b =>
                {
                    b.Property<int>("Sdgs531Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AgeGroup");

                    b.Property<string>("CountryOrAreaCode");

                    b.Property<string>("CountryOrAreaName");

                    b.Property<string>("Frequency");

                    b.Property<int>("Goal");

                    b.Property<string>("IndicatorDescription");

                    b.Property<string>("IndicatorId");

                    b.Property<string>("IndicatorRef");

                    b.Property<bool?>("LDC");

                    b.Property<bool?>("LLDC");

                    b.Property<string>("Location");

                    b.Property<string>("ParentCountryOrAreaCode");

                    b.Property<bool?>("SIDS");

                    b.Property<string>("SeriesCode");

                    b.Property<string>("SeriesDescription");

                    b.Property<string>("SeriesType");

                    b.Property<string>("Sex");

                    b.Property<string>("SourceType");

                    b.Property<string>("Target");

                    b.Property<string>("Unit");

                    b.Property<string>("UnitMultiplier");

                    b.Property<string>("ValueType");

                    b.Property<string>("Y2000");

                    b.Property<string>("Y2000FN");

                    b.Property<decimal?>("Y2001");

                    b.Property<string>("Y2001FN");

                    b.Property<decimal?>("Y2002");

                    b.Property<string>("Y2002FN");

                    b.Property<decimal?>("Y2003");

                    b.Property<string>("Y2003FN");

                    b.Property<decimal?>("Y2004");

                    b.Property<string>("Y2004FN");

                    b.Property<decimal?>("Y2005");

                    b.Property<string>("Y2005FN");

                    b.Property<decimal?>("Y2006");

                    b.Property<string>("Y2006FN");

                    b.Property<decimal?>("Y2007");

                    b.Property<string>("Y2007FN");

                    b.Property<decimal?>("Y2008");

                    b.Property<string>("Y2008FN");

                    b.Property<decimal?>("Y2009");

                    b.Property<string>("Y2009FN");

                    b.Property<decimal?>("Y2010");

                    b.Property<string>("Y2010FN");

                    b.Property<decimal?>("Y2011");

                    b.Property<string>("Y2011FN");

                    b.Property<decimal?>("Y2012");

                    b.Property<string>("Y2012FN");

                    b.Property<decimal?>("Y2013");

                    b.Property<string>("Y2013FN");

                    b.Property<decimal?>("Y2014");

                    b.Property<string>("Y2014FN");

                    b.Property<decimal?>("Y2015");

                    b.Property<string>("Y2015FN");

                    b.Property<decimal?>("Y2016");

                    b.Property<string>("Y2016FN");

                    b.HasKey("Sdgs531Id");

                    b.ToTable("Sdgs531s");
                });

            modelBuilder.Entity("StephJob.Core.Domain.Sdgs861", b =>
                {
                    b.Property<int>("Sdgs861Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AgeGroup");

                    b.Property<string>("CountryOrAreaCode");

                    b.Property<string>("CountryOrAreaName");

                    b.Property<string>("Frequency");

                    b.Property<int>("Goal");

                    b.Property<string>("IndicatorDescription");

                    b.Property<string>("IndicatorId");

                    b.Property<string>("IndicatorRef");

                    b.Property<bool?>("LDC");

                    b.Property<bool?>("LLDC");

                    b.Property<string>("Location");

                    b.Property<string>("ParentCountryOrAreaCode");

                    b.Property<bool?>("SIDS");

                    b.Property<string>("SeriesCode");

                    b.Property<string>("SeriesDescription");

                    b.Property<string>("SeriesType");

                    b.Property<string>("Sex");

                    b.Property<string>("SourceType");

                    b.Property<string>("Target");

                    b.Property<string>("Unit");

                    b.Property<string>("UnitMultiplier");

                    b.Property<string>("ValueType");

                    b.Property<string>("Y2000");

                    b.Property<string>("Y2000FN");

                    b.Property<decimal?>("Y2001");

                    b.Property<string>("Y2001FN");

                    b.Property<decimal?>("Y2002");

                    b.Property<string>("Y2002FN");

                    b.Property<decimal?>("Y2003");

                    b.Property<string>("Y2003FN");

                    b.Property<decimal?>("Y2004");

                    b.Property<string>("Y2004FN");

                    b.Property<decimal?>("Y2005");

                    b.Property<string>("Y2005FN");

                    b.Property<decimal?>("Y2006");

                    b.Property<string>("Y2006FN");

                    b.Property<decimal?>("Y2007");

                    b.Property<string>("Y2007FN");

                    b.Property<decimal?>("Y2008");

                    b.Property<string>("Y2008FN");

                    b.Property<decimal?>("Y2009");

                    b.Property<string>("Y2009FN");

                    b.Property<decimal?>("Y2010");

                    b.Property<string>("Y2010FN");

                    b.Property<decimal?>("Y2011");

                    b.Property<string>("Y2011FN");

                    b.Property<decimal?>("Y2012");

                    b.Property<string>("Y2012FN");

                    b.Property<decimal?>("Y2013");

                    b.Property<string>("Y2013FN");

                    b.Property<decimal?>("Y2014");

                    b.Property<string>("Y2014FN");

                    b.Property<decimal?>("Y2015");

                    b.Property<string>("Y2015FN");

                    b.Property<decimal?>("Y2016");

                    b.Property<string>("Y2016FN");

                    b.HasKey("Sdgs861Id");

                    b.ToTable("Sdgs861s");
                });

            modelBuilder.Entity("StephJob.Core.Domain.Soc2010", b =>
                {
                    b.Property<int>("Soc2010Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Title");

                    b.HasKey("Soc2010Id");

                    b.ToTable("Soc2010s");
                });

            modelBuilder.Entity("StephJob.Core.Domain.WorldBankGdp", b =>
                {
                    b.Property<int>("WorldBankGdpId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryCode");

                    b.Property<string>("CountryName");

                    b.Property<string>("IndicatorCode");

                    b.Property<string>("IndicatorName");

                    b.Property<decimal?>("Y1960");

                    b.Property<decimal?>("Y1961");

                    b.Property<decimal?>("Y1962");

                    b.Property<decimal?>("Y1963");

                    b.Property<decimal?>("Y1964");

                    b.Property<decimal?>("Y1965");

                    b.Property<decimal?>("Y1966");

                    b.Property<decimal?>("Y1967");

                    b.Property<decimal?>("Y1968");

                    b.Property<decimal?>("Y1969");

                    b.Property<decimal?>("Y1970");

                    b.Property<decimal?>("Y1971");

                    b.Property<decimal?>("Y1972");

                    b.Property<decimal?>("Y1973");

                    b.Property<decimal?>("Y1974");

                    b.Property<decimal?>("Y1975");

                    b.Property<decimal?>("Y1976");

                    b.Property<decimal?>("Y1977");

                    b.Property<decimal?>("Y1978");

                    b.Property<decimal?>("Y1979");

                    b.Property<decimal?>("Y1980");

                    b.Property<decimal?>("Y1981");

                    b.Property<decimal?>("Y1982");

                    b.Property<decimal?>("Y1983");

                    b.Property<decimal?>("Y1984");

                    b.Property<decimal?>("Y1985");

                    b.Property<decimal?>("Y1986");

                    b.Property<decimal?>("Y1987");

                    b.Property<decimal?>("Y1988");

                    b.Property<decimal?>("Y1989");

                    b.Property<decimal?>("Y1990");

                    b.Property<decimal?>("Y1991");

                    b.Property<decimal?>("Y1992");

                    b.Property<decimal?>("Y1993");

                    b.Property<decimal?>("Y1994");

                    b.Property<decimal?>("Y1995");

                    b.Property<decimal?>("Y1996");

                    b.Property<decimal?>("Y1997");

                    b.Property<decimal?>("Y1998");

                    b.Property<decimal?>("Y1999");

                    b.Property<decimal?>("Y2000");

                    b.Property<decimal?>("Y2001");

                    b.Property<decimal?>("Y2002");

                    b.Property<decimal?>("Y2003");

                    b.Property<decimal?>("Y2004");

                    b.Property<decimal?>("Y2005");

                    b.Property<decimal?>("Y2006");

                    b.Property<decimal?>("Y2007");

                    b.Property<decimal?>("Y2008");

                    b.Property<decimal?>("Y2009");

                    b.Property<decimal?>("Y2010");

                    b.Property<decimal?>("Y2011");

                    b.Property<decimal?>("Y2012");

                    b.Property<decimal?>("Y2013");

                    b.Property<decimal?>("Y2014");

                    b.Property<decimal?>("Y2015");

                    b.Property<decimal?>("Y2016");

                    b.HasKey("WorldBankGdpId");

                    b.ToTable("WorldBankGdps");
                });
#pragma warning restore 612, 618
        }
    }
}
