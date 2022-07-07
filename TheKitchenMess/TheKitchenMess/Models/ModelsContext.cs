﻿using Microsoft.EntityFrameworkCore;

namespace TheKitchenMess.Models
{
    public class ModelsContext : DbContext
    {
        public ModelsContext(DbContextOptions<ModelsContext> options) : base(options)
        {
        }

        public DbSet<Root>? RecipeRoot { get; set; }
        public DbSet<Result>? Recipes { get; set; }
        public DbSet<Nutrient>? Nutrients { get; set; }
        public DbSet<Nutrition>? Nutrition { get; set; }
    }
}