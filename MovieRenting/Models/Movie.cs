﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRenting.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }
        [Required]
        public byte GenreId { get; set; }



        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
    }
}