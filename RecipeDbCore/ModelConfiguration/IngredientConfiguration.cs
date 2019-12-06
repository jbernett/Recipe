using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeDbCore.ModelConfiguration
{
    class IngredientConfiguration
    {
        public IngredientConfiguration(EntityTypeBuilder<Ingredient> entity)
        {
            entity.HasIndex(o => o.Name);

            entity.Property(o => o.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(o => o.Type)
                .HasConversion<int>()
                .IsRequired();
        }
    }
}
