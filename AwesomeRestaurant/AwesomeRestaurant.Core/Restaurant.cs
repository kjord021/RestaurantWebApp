﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRestaurant.Core
{

    public class Restaurant
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int ID { get; set; }
        public CuisineType Cuisine { get; set; }

    }
}
