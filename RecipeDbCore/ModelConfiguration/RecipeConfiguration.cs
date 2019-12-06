
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeDomain.Models;

namespace RecipeDbCore.ModelConfiguration
{
    public class RecipeConfiguration
    {
        public RecipeConfiguration(EntityTypeBuilder<Recipe> entity)
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
