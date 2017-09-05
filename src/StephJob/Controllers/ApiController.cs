namespace StephJob.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PlutoWeb.Persistence;
    using StephJob.Core.Repositories;
    using StephJob.Persistance;
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
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.unitOfWork.Dispose();
            }
        }
    }
}
