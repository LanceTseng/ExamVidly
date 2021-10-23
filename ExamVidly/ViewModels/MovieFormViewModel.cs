using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using ExamVidly.Models;

namespace ExamVidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public Movie Movie { get; set; }
    }
}