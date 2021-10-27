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

        [StringLength(255)]
        public string Name { get; set; }

        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleasedDate { get; set; }

        public byte NumberInStock { get; set; }
    }
}