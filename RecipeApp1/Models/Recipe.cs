﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RecipeApp1.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        [System.ComponentModel.DisplayName("Recipe Name")]
        [Required(ErrorMessage = "Recipe Name is required")]
        public string RecipeName { get; set; }
        [System.ComponentModel.DisplayName("Difficulty Rating 1-5")]
        [Required(ErrorMessage = "Rating is required")]
        public int Rating { get; set; }
        [System.ComponentModel.DisplayName("Hours")]
        [Required(ErrorMessage = "Hours is required")]
        public int Hours { get; set; }
        [System.ComponentModel.DisplayName("Minutes")]
        [Required(ErrorMessage = "Minutes is required")]      
        public int Minutes { get; set; }
        [System.ComponentModel.DisplayName("Instructions")]
        [Required(ErrorMessage = "Recipe Intstructions required")]
        public string Instructions { get; set; }
    }
}