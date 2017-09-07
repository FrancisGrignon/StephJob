namespace StephJob.Core.Domain
{
    public class Naics
    {
        public int NaicsId { get; set; }

        public int Level { get; set; }

        public string Hierarchical { get; set; }

        public int Code { get; set; }

        public string Title { get; set; }

        public string Superscript { get; set; }

        public string Definition { get; set; }
    }
}
