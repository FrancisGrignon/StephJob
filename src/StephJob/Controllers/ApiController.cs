namespace StephJob.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PlutoWeb.Persistence;
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;
    using StephJob.Persistance;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ApiController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ApiController(StephContext stephContext)
        {
            this.unitOfWork = new UnitOfWork(stephContext);
        }

        [HttpGet]
        public JsonResult GetIndustry(string term = "")
        {
            var industry = unitOfWork.Naics.Find(p => p.Title.Contains(term)).Select(p => new { Name = p.Title, Id = p.NaicsId }).Distinct();

            return Json(industry);
        }

        [HttpGet]
        public JsonResult GetOccupation(string term = "")
        {
            var occupation = unitOfWork.Noc2011s.Find(p => p.Title.Contains(term)).Select(p => new { Name = p.Title, Id = p.Noc2011Id }).Distinct();

            return Json(occupation);
        }

        [HttpGet]
        public JsonResult GetEmploymentProspectChart(int value)
        {

            EmploymentProjection v = unitOfWork.EmploymentProjections.Find(p => p.NocCode == value).SingleOrDefault();

            var chart = new Chart();

            if (v == null)
            {
                string[] years = new string[] { "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" };
                int[] vs = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                chart.Labels = years;
                chart.Data = vs;
            }
            else
            {
                string[] years = new string[] { "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" };
                int[] vs = new int[] { v.Y2014, v.Y2015, v.Y2016, v.Y2017, v.Y2018, v.Y2019, v.Y2020, v.Y2021, v.Y2022, v.Y2023, v.Y2024 };
                chart.Labels = years;
                chart.Data = vs;
            }

            return Json(chart);
        }

        [HttpGet]
        public JsonResult GetRetirementProjectionChart(int id)
        {
            var v = unitOfWork.RetirementProjections.Find(p => p.NocCode == id).SingleOrDefault();
            var chart = new Chart()
            {
                Labels = new string[] { "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" }
            };
            if (null == v)
            {
                chart.Data = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            }
            else
            {
                chart.Data = new int[] { v.Y2014, v.Y2015, v.Y2016, v.Y2017, v.Y2018, v.Y2019, v.Y2020, v.Y2021, v.Y2022, v.Y2023, v.Y2024 };
            }
            return Json(chart);
        }
        
        public class Chart
        {
            public string[] Labels { get; set; }

            public int[] Data { get; set; }
        }

        public class ChartGdp
        {
            public string[] Labels { get; set; }

            public int[] Total { get; set; }

            public int[] Industry { get; set; }
        }

        [HttpGet]
        public JsonResult GetGdpChart(string id)
        {
            var t = unitOfWork.GrossDomesticProducts.Find(p => p.NaicsCode2Digits == "1").SingleOrDefault();
            var v = unitOfWork.GrossDomesticProducts.Find(p => p.NaicsCode2Digits == id).SingleOrDefault();

            var chart = new ChartGdp()
            {
                Labels = new string[] { "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017" },
                Total = new int[] { t.Y1997, t.Y1998, t.Y1999, t.Y2000, t.Y2001, t.Y2002, t.Y2003, t.Y2004, t.Y2005, t.Y2006, t.Y2007, t.Y2008, t.Y2009, t.Y2010, t.Y2011, t.Y2012, t.Y2013, t.Y2014, t.Y2015, t.Y2016, t.Y2017 }
            };

            if (null == v)
            {
                chart.Industry = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            }
            else
            {
                chart.Industry = new int[] { v.Y1997, v.Y1998, v.Y1999, v.Y2000, v.Y2001, v.Y2002, v.Y2003, v.Y2004, v.Y2005, v.Y2006, v.Y2007, v.Y2008, v.Y2009, v.Y2010, v.Y2011, v.Y2012, v.Y2013, v.Y2014, v.Y2015, v.Y2016, v.Y2017 };
            }

            return Json(chart);
        }

        [HttpGet]
        public JsonResult GetOccupationIndicators(int id)
        {
            var indicator = new OccupationIndicators();

            return Json(indicator);
        }

        [HttpGet]
        public JsonResult GetIndustryIndicators(string id)
        {
            var indicator = new IndustryIndicators();

            var earningByWeek = unitOfWork.EmploymentAveWeekEarnings.Find(p => p.NaicsCode2Digits == id).SingleOrDefault();

            if (null == earningByWeek)
            {
                indicator.EarningByWeek = "NA";
            }
            else
            {
                indicator.EarningByWeek = earningByWeek.AverageWeeklyEarning2016.ToString("C") + "CAD";
            }

            var greenGood = unitOfWork.GreenGoodServices.Find(p => p.NaicsCode2Digit == id).SingleOrDefault();

            if (null == greenGood)
            {
                indicator.GreenGoodsAndServices = "NA";
            }
            else
            {
                indicator.GreenGoodsAndServices = greenGood.GgsPercent.ToString();
            }

            var naics = unitOfWork.Naics2Digits.Find(p => p.NaicsCode2Digits == id).SingleOrDefault();

            if (null == naics)
            {
                indicator.IndustryName = "NA";
            }
            else
            {
                indicator.IndustryName = naics.Sector;
            }

            var gdpTotal = unitOfWork.GrossDomesticProducts.Find(p => p.NaicsCode2Digits == "1").SingleOrDefault();
            var gdpIndustry = unitOfWork.GrossDomesticProducts.Find(p => p.NaicsCode2Digits == id).SingleOrDefault();

            if (null == gdpTotal || null == gdpIndustry)
            {
                indicator.IndustryProportion = "NA";
            }
            else
            {
                indicator.IndustryProportion = (gdpIndustry.Y2017 * 100 / gdpTotal.Y2017).ToString("F2");
            }

            var physicalFlow = unitOfWork.PhysicalFlowAcccounts.Find(p => p.NaicsCode2Digits == id).SingleOrDefault();

            if (null == physicalFlow)
            {
                indicator.PhysicalFlowAcccount = "NA";
            }
            else
            {
                indicator.PhysicalFlowAcccount = physicalFlow.Kilotonnes.ToString("F2");
            }

            var unemployment = unitOfWork.UnemploymentJobVacanciesRatios.Find(p => p.NaicsCode2Digits == id).SingleOrDefault();

            if (null == unemployment)
            {
                indicator.UnemploymentJobVacanciesRatio = "NA";
            }
            else
            {
                indicator.UnemploymentJobVacanciesRatio = unemployment.Y2016.ToString("F2");
            }

            return Json(indicator);
        }

        public class OccupationIndicators
        {
            public string Code { get; set; }

            public string Title { get; set; }
        }

        public class IndustryIndicators
        {
            public string Code { get; set; }

            public string IndustryName { get; set; }

            public string EarningByWeek { get; set; }

            public string EnergyUtilisation { get; set; }

            public string GreenGoodsAndServices { get; set; }

            public string GreenHouseGas { get; set; }

            public string IndustryProportion { get; set; }

            public string PhysicalFlowAcccount { get; set; }

            public string UnemploymentJobVacanciesRatio { get; set; }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.unitOfWork.Dispose();
            }
        }
    }
}
