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
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("Review")]
        public IActionResult Review()
        {
            var model = new ReviewModel();

            model.Industries = unitOfWork.Naics2Digits.GetAll().Select(p => new { Name = p.Sector.EndWithDots(), Id = p.NaicsCode2Digits }).Distinct().OrderBy(p => p.Name).Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name });
            model.Occupations = unitOfWork.Noc2011s.GetAll().Select(p => new { Name = p.Title.EndWithDots(), Id = p.Code }).Distinct().OrderBy(p => p.Name).Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name });

            return View(model);
        }

        [Route("About")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Data")]
        public IActionResult Data()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("Bio")]
        public IActionResult Bio()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
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