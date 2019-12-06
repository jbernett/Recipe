using RecipeDomain.Converters;
using RecipeDomain.Enums;
using RecipeDomain.Models.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeDomain.Models
{
    public class RecipeViewModel : IConvertModel<RecipeViewModel, Recipe>
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public RecipeType Type { get; set; }
        public TimeSpan PrepTime { get; set; }
        public TimeSpan CookTime { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new HashSet<RecipeIngredient>();
        public Recipe Convert() => new Recipe
        {
            Guid = Guid,
            Name = Name,
            Type = Type,
            PrepTime = PrepTime,
            CookTime = CookTime
        };
    }
}
