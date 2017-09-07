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
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.unitOfWork.Dispose();
            }
        }
    }
}
