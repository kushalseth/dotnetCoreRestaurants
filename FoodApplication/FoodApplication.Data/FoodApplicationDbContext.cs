﻿using FoodApplication.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApplication.Data
{
    public class FoodApplicationDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
