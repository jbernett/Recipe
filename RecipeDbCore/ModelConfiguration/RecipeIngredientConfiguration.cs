using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeDbCore.ModelConfiguration
{
    class RecipeIngredientConfiguration
    {
        public RecipeIngredientConfiguration(EntityTypeBuilder<RecipeIngredient> entity)
        {
            entity.Property(o => o.IngredientGuid)
                .IsRequired();

            entity.Property(o => o.RecipeGuid)
                .IsRequired();

            entity.Property(o => o.Amount)
                .IsRequired();

            entity.Property(o => o.Measurement)
                .IsRequired()
                .HasConversion<int>();

            entity.HasOne(o => o.Recipe)
                .WithMany(o => o.RecipeIngredients)
                .HasForeignKey(o => o.RecipeGuid);

            entity.HasOne(o => o.Ingredient)
                .WithMany(o => o.RecipeIngredients)
                .HasForeignKey(o => o.IngredientGuid);
        }
    }
}
