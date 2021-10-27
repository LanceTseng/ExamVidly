﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ExamVidly.Models;

namespace ExamVidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        public DateTime ReleasedDate { get; set; }

        [Required]
        [Range(1,20)]
        public byte NumberInStock { get; set; }
    }
}