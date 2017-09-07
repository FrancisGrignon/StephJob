namespace StephJob.Core.Domain
{
    public class EmploymentAveWeekEarning
    {
        public int EmploymentAveWeekEarningId { get; set; }

        public string RefDate { get; set; }

        public string Geo { get; set; }

        public string Variable { get; set; }

        public string Naics { get; set; }

        public string NaicsCode2Digits { get; set; }

        public decimal AverageWeeklyEarning2016 { get; set; }
    }
}
