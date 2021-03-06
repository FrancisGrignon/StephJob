﻿namespace StephJob.Persistance
{
    using CsvHelper;
    using Microsoft.EntityFrameworkCore;
    using StephJob.Core.Domain;
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Threading;

    public static class DbInitializer
    {
        public static void Initialize(StephContext context)
        {
            context.Database.Migrate();

            SeedFromCsv<Sdgs372>(context, @"wwwroot\datasets\Sdgs372.csv");
            SeedFromCsv<Sdgs411>(context, @"wwwroot\datasets\Sdgs411.csv");
            SeedFromCsv<Sdgs431>(context, @"wwwroot\datasets\Sdgs431.csv");
            SeedFromCsv<Sdgs441>(context, @"wwwroot\datasets\Sdgs441.csv");
            SeedFromCsv<Sdgs531>(context, @"wwwroot\datasets\Sdgs531.csv");
            SeedFromCsv<Sdgs861>(context, @"wwwroot\datasets\Sdgs861.csv");
            SeedFromCsv<Sdgs372>(context, @"wwwroot\datasets\sdgs372.csv");
            SeedFromCsv<WorldBankGdp>(context, @"wwwroot\datasets\worldbank.NY.GDP.MKTP.CD.csv");
            SeedFromCsv<Naics>(context, @"wwwroot\datasets\NAICS-SCIAN-2012-Structure_B.csv");
            SeedFromCsv<Soc2010>(context, @"wwwroot\datasets\soc_2010_alphabetical_index.csv");
            SeedFromCsv<Noc2011>(context, @"wwwroot\datasets\esdc.noc2011.csv");
            SeedFromCsv<FutureEmployment>(context, @"wwwroot\datasets\FutureOfEmployment.csv");
            SeedFromCsv<EmploymentAveWeekEarning>(context, @"wwwroot\datasets\employment and average weekly earnings.csv");
            SeedFromCsv<Naics2Digit>(context, @"wwwroot\datasets\statcan_naics2012_2digits.csv");
            SeedFromCsv<RetirementProjection>(context, @"wwwroot\datasets\Retirement projections.csv");
            SeedFromCsv<EmploymentProjection>(context, @"wwwroot\datasets\Employment projections.csv");
            SeedFromCsv<PhysicalFlowAcccount>(context, @"wwwroot\datasets\GHG.csv");
            SeedFromCsv<GreenGoodService>(context, @"wwwroot\datasets\Green goods and services (US).csv");
            SeedFromCsv<GrossDomesticProduct>(context, @"wwwroot\datasets\Gross domestic product (GDP) at basic prices.csv");
            SeedFromCsv<UnemploymentJobVacanciesRatio>(context, @"wwwroot\datasets\NAICS_NOC_ratio.csv");

            context.SaveChanges();
        }

        private static void SeedFromCsv<TEntity>(StephContext context, string path) where TEntity : class
        {
            var currentUICulture = Thread.CurrentThread.CurrentUICulture;
            var currentCulture = Thread.CurrentThread.CurrentCulture;

            try
            {
                var culture = new CultureInfo("en-US");

                Thread.CurrentThread.CurrentCulture = culture;
                Thread.CurrentThread.CurrentUICulture = culture;

                if (false == context.Set<TEntity>().Any())
                {
                    using (var textReader = File.OpenText(path))
                    {
                        using (var csv = new CsvReader(textReader))
                        {
                            csv.Configuration.WillThrowOnMissingField = false;

                            var records = csv.GetRecords<TEntity>();

                            context.Set<TEntity>().AddRange(records);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = currentUICulture;
                Thread.CurrentThread.CurrentCulture = currentCulture;
            }
        }
    }
}
