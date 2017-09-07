namespace StephJob.Core.Domain
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class PhysicalFlowAcccount
    {
        public int PhysicalFlowAcccountId { get; set; }

        public string Geography { get; set; }

        public string Sector { get; set; }
        
        [Column("2010")]
        public int Y2010 { get; set; }

        [Column("2011")]
        public int Y2011 { get; set; }

        [Column("2012")]
        public int Y2012 { get; set; }

        [Column("2013")]
        public int Y2013 { get; set; }

        [Column("2014")]
        public int Y2014 { get; set; }

    }
}
