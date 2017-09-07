namespace StephJob.Core.Domain
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class GrossDomesticProduct
    {
        public int GrossDomesticProductId { get; set; }

        public string Geography { get; set; }

        public string SeasonalAdjustment { get; set; }

        public string Prices { get; set; }

        public string Naics { get; set; }

        public string NaicsCode2Digits { get; set; }

        [Column("1997")]
        public int Y1997 { get; set; }

        [Column("1998")]
        public int Y1998 { get; set; }

        [Column("1999")]
        public int Y1999{ get; set; }

        [Column("2000")]
        public int Y2000 { get; set; }

        [Column("2001")]
        public int Y2001 { get; set; }

        [Column("2002")]
        public int Y2002 { get; set; }

        [Column("2003")]
        public int Y2003 { get; set; }

        [Column("2004")]
        public int Y2004 { get; set; }

        [Column("2005")]
        public int Y2005 { get; set; }

        [Column("2006")]
        public int Y2006 { get; set; }

        [Column("2007")]
        public int Y2007 { get; set; }

        [Column("2008")]
        public int Y2008 { get; set; }

        [Column("2009")]
        public int Y2009 { get; set; }

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

        [Column("2015")]
        public int Y2015 { get; set; }

        [Column("2016")]
        public int Y2016 { get; set; }

        [Column("2017")]
        public int Y2017 { get; set; }
    }
}
