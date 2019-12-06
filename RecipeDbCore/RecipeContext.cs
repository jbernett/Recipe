using Microsoft.EntityFrameworkCore;
using RecipeDbCore.ModelConfiguration;
using RecipeDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeDbCore
{
    public class RecipeContext : DbContext
    {
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        public RecipeContext(DbContextOptions options) : base(options) { }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new RecipeConfiguration(modelBuilder.Entity<Recipe>());
            new IngredientConfiguration(modelBuilder.Entity<Ingredient>());
            new RecipeIngredientConfiguration(modelBuilder.Entity<RecipeIngredient>());
        }

    }
}
