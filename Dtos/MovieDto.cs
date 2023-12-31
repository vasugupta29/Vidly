﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {

        public int Id { get; set; }


        [Required]
        [StringLength(250)]
        public string Name { get; set; }


        [Required]
        public int GenreId { get; set; }


        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }


        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}