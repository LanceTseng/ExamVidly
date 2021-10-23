using System;
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

        [Required]
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre Type")]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }
    }
}