namespace StephJob.Core.Domain
{
    interface ISdgs
    {
        int Goal { get; set; }
        string Target { get; set; }
        string IndicatorRef { get; set; }
        string IndicatorId { get; set; }
        string IndicatorDescription { get; set; }
        string SeriesCode { get; set; }
        string SeriesType { get; set; }
        string SeriesDescription { get; set; }
        string ParentCountryOrAreaCode { get; set; }
        string CountryOrAreaCode { get; set; }
        string CountryOrAreaName { get; set; }
        bool? LDC { get; set; }
        bool? LLDC { get; set; }
        bool? SIDS { get; set; }
        string Frequency { get; set; }
        string SourceType { get; set; }
        string AgeGroup { get; set; }
        string Location { get; set; }
        string Sex { get; set; }
        string ValueType { get; set; }
        string Unit { get; set; }
        string UnitMultiplier { get; set; }
        string Y2000 { get; set; }
        string Y2000FN { get; set; }
        decimal? Y2001 { get; set; }
        string Y2001FN { get; set; }
        decimal? Y2002 { get; set; }
        string Y2002FN { get; set; }
        decimal? Y2003 { get; set; }
        string Y2003FN { get; set; }
        decimal? Y2004 { get; set; }
        string Y2004FN { get; set; }
        decimal? Y2005 { get; set; }
        string Y2005FN { get; set; }
        decimal? Y2006 { get; set; }
        string Y2006FN { get; set; }
        decimal? Y2007 { get; set; }
        string Y2007FN { get; set; }
        decimal? Y2008 { get; set; }
        string Y2008FN { get; set; }
        decimal? Y2009 { get; set; }
        string Y2009FN { get; set; }
        decimal? Y2010 { get; set; }
        string Y2010FN { get; set; }
        decimal? Y2011 { get; set; }
        string Y2011FN { get; set; }
        decimal? Y2012 { get; set; }
        string Y2012FN { get; set; }
        decimal? Y2013 { get; set; }
        string Y2013FN { get; set; }
        decimal? Y2014 { get; set; }
        string Y2014FN { get; set; }
        decimal? Y2015 { get; set; }
        string Y2015FN { get; set; }
        decimal? Y2016 { get; set; }
        string Y2016FN { get; set; }
    }
}
