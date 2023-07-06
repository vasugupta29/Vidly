using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }


        [Required]
        [StringLength(250)]
        public string Name { get; set; }


       
        public Genre Genre { get; set; }  //Navigation Property

        [Required]
        [Display(Name= "Genre")]
        public int GenreId { get; set; }


        public DateTime DateAdded { get; set;}


        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }


        [Range(1, 20)]
        [Display(Name = "Number In Stock")]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }

    }
}