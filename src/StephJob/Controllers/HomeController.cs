namespace StephJob.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using PlutoWeb.Persistence;
    using StephJob.Core.Repositories;
    using StephJob.Models;
    using StephJob.Persistance;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public HomeController(StephContext stephContext)
       {
            this.unitOfWork = new UnitOfWork(stephContext);
        }

        public IActionResult Index()
        {
            var model = new IndexModel();

            model.Industries = unitOfWork.Naics.Find(p => p.Level == 2).Select(p => new { Name = p.Title, Id = p.NaicsId }).Distinct().OrderBy(p => p.Name).Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name });
            model.Occupations = unitOfWork.Noc2011s.GetAll().Select(p => new { Name = p.Title, Id = p.Noc2011Id }).Distinct().OrderBy(p => p.Name).Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name });

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult GetIndustry(string term = "")
        {
            var industry = unitOfWork.Naics.Find(p => p.Title.Contains(term)).Select(p => new { Name = p.Title, Id = p.NaicsId }).Distinct();

            return Json(industry);
        }

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