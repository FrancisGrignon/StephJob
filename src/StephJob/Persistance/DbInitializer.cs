namespace StephJob.Persistance
{
    using CsvHelper;
    using StephJob.Core.Domain;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Threading;

    public static class DbInitializer
    {
        public static void Initialize(StephContext context)
        {
            context.Database.EnsureCreated();
            
            if (false == context.Sdgs372s.Any())
            {
                var currentUICulture = Thread.CurrentThread.CurrentUICulture;
                var currentCulture = Thread.CurrentThread.CurrentCulture;

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

                using (var textReader = File.OpenText(@"datasets\sdgs372.csv"))
                {
                    using (var csv = new CsvReader(textReader))
                    {
                        csv.Configuration.WillThrowOnMissingField = false;

                        var records = csv.GetRecords<Sdgs372>();

                        context.Sdgs372s.AddRange(records);
                    }
                }

                using (var textReader = File.OpenText(@"datasets\sdgs411.csv"))
                {
                    using (var csv = new CsvReader(textReader))
                    {
                        csv.Configuration.WillThrowOnMissingField = false;

                        var records = csv.GetRecords<Sdgs411>();

                        context.Sdgs411s.AddRange(records);
                    }
                }

                using (var textReader = File.OpenText(@"datasets\sdgs431.csv"))
                {
                    using (var csv = new CsvReader(textReader))
                    {
                        csv.Configuration.WillThrowOnMissingField = false;

                        var records = csv.GetRecords<Sdgs431>();

                        context.Sdgs431s.AddRange(records);
                    }
                }

                using (var textReader = File.OpenText(@"datasets\sdgs441.csv"))
                {
                    using (var csv = new CsvReader(textReader))
                    {
                        csv.Configuration.WillThrowOnMissingField = false;

                        var records = csv.GetRecords<Sdgs441>();

                        context.Sdgs441s.AddRange(records);
                    }
                }

                using (var textReader = File.OpenText(@"datasets\sdgs531.csv"))
                {
                    using (var csv = new CsvReader(textReader))
                    {
                        csv.Configuration.WillThrowOnMissingField = false;

                        var records = csv.GetRecords<Sdgs531>();

                        context.Sdgs531s.AddRange(records);
                    }
                }

                using (var textReader = File.OpenText(@"datasets\sdgs861.csv"))
                {
                    using (var csv = new CsvReader(textReader))
                    {
                        csv.Configuration.WillThrowOnMissingField = false;

                        var records = csv.GetRecords<Sdgs861>();

                        context.Sdgs861s.AddRange(records);
                    }
                }

                context.SaveChanges();

                Thread.CurrentThread.CurrentUICulture = currentUICulture;
                Thread.CurrentThread.CurrentCulture = currentCulture;
            }
        }
    }
}
