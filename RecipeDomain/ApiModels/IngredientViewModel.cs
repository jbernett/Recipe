using RecipeDomain.Converters;
using RecipeDomain.Enums;
using RecipeDomain.Models.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeDomain.Models
{
    public class IngredientViewModel : IConvertModel<IngredientViewModel, Ingredient>
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public IngredientType Type { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new HashSet<RecipeIngredient>();
        public Ingredient Convert() => new Ingredient
        {
            Guid = Guid,
            Name = Name,
            Type = Type
        };
    }
    
}
