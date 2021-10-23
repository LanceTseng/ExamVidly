﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ExamVidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string  Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre Type")]
        public byte GenreId { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }
    }
}