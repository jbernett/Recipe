using RecipeDomain.Converters;
using RecipeDomain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeDomain.Models
{
    public class RecipeIngredientViewModel : IConvertModel<RecipeIngredientViewModel, RecipeIngredient>
    {
        public Guid RecipeGuid { get; set; }
        public Guid IngredientGuid { get; set; }
        public decimal Amount { get; set; }
        public MeasurementType Measurement { get; set; }
        public Ingredient Ingredient { get; set; }
        public Recipe Recipe { get; set; }
        public RecipeIngredient Convert() => new RecipeIngredient
        {
            RecipeGuid = RecipeGuid,
            IngredientGuid = IngredientGuid,
            Amount = Amount,
            Measurement = Measurement
        };
    }
}
