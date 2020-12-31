using AwesomeRestaurant.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeResturant.AwesomeRestaurant.Data
{
    public class AwesomeRestaurantDbContext : DbContext
    {
        public AwesomeRestaurantDbContext(DbContextOptions<AwesomeRestaurantDbContext> options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }

    }
}
