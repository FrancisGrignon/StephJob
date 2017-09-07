namespace StephJob.Core.Domain
{
    public class FutureEmployment
    {
        public int FutureEmploymentId { get; set; }

        public int Rank { get; set; }

        public decimal Probability { get; set; }

        public string SocCode { get; set; }

        public string Occupation { get; set; }
    }
}
