namespace StephJob.Core.Domain
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class EmploymentProjection
    {
        public int EmploymentProjectionId { get; set; }

        public int NocCode{ get; set; }

        public string Occupation{ get; set; }

        [Column("2014")]
        public int Y2014{ get; set; }

        [Column("2015")]
        public int Y2015 { get; set; }

        [Column("2016")]
        public int Y2016 { get; set; }

        [Column("2017")]
        public int Y2017 { get; set; }

        [Column("2018")]
        public int Y2018 { get; set; }

        [Column("2019")]
        public int Y2019 { get; set; }

        [Column("2020")]
        public int Y2020 { get; set; }

        [Column("2021")]
        public int Y2021 { get; set; }

        [Column("2022")]
        public int Y2022 { get; set; }

        [Column("2023")]
        public int Y2023 { get; set; }
        
        [Column("2024")]
        public int Y2024 { get; set; }
    }
}
