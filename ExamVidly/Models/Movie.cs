using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamVidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre Type")]
        public byte GenreId { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number In Stock")]
        public byte NumberInStock { get; set; }

        [Required]
        public byte NumberAvailable { get; set; }

    }
}