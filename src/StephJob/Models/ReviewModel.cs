﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace StephJob.Models
{
    public class ReviewModel
    {
        public string Industry { get; set; }
        
        public string Occupation { get; set; }

        public IEnumerable<SelectListItem> Industries { get; set; }

        public IEnumerable<SelectListItem> Occupations { get; set; }


        //Employment values
        public decimal EarningsPerWeek { get; set; }

        
    }
}
