using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;
using Microsoft.EntityFrameworkCore;

namespace OdeToFood.Data
{

    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options)
            :base(options)
        {
            
        }
        public DbSet<Restaurant> Restaurants { get; set; }
    
    }
}
