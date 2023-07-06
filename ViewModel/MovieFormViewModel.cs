using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }


        [Required]
        [StringLength(250)]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Genre")]
        public int? GenreId { get; set; }


        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }


        [Range(1, 20)]
        [Required]
        [Display(Name = "Number In Stock")]
        public byte? NumberInStock { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
            
        }   

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}