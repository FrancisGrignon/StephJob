namespace StephJob.Core.Domain
{
    public class GreenGoodService
    {
        public int GreenGoodServiceId { get; set; }

        public string Industry { get; set; }

        public string NaicsCode2Digit { get; set; }

        public int GgsEmployment { get; set; }

        public decimal GgsPercent { get; set; }

        public int TotalEmployment { get; set; }
    }
}