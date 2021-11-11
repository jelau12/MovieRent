using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRenting.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter movie name")]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage ="Please select genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Please enter movie release date")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage ="Please enter DateAdded")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20, ErrorMessage ="Number must be between 1 and 20")]
        [Required(ErrorMessage ="Please Enter number in stock")]
        public int NumberInStock { get; set; }
    }
}