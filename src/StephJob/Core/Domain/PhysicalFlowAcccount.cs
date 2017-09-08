namespace StephJob.Core.Domain
{
    public class PhysicalFlowAcccount
    {
        public int PhysicalFlowAcccountId { get; set; }

        public string NaicsCode2Digits { get; set; }

        public string Naics { get; set; }

        public string Unknown1 { get; set; }

        public string Unknown2 { get; set; }

        public decimal Kilotonnes { get; set; }
    }
}
