﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AwesomeRestaurant.Core
{

    public class Restaurant
    {
        [Required, StringLength(80)]
        public string Name { get; set; }
        [Required, StringLength(255)]
        public string Location { get; set; }
        public int ID { get; set; }
        public CuisineType Cuisine { get; set; }

    }
}
