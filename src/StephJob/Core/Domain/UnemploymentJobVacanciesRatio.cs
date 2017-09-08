namespace StephJob.Core.Domain
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class UnemploymentJobVacanciesRatio
    {
        public int UnemploymentJobVacanciesRatioId { get; set; }

        public string NaicsCode2Digits { get; set; }

        public string Geography { get; set; }

        public string Naics { get; set; }

        [Column("2016")]
        public decimal Y2016 { get; set; }
    }
}
