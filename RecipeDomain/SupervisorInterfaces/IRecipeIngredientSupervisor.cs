using RecipeDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeDomain.SupervisorInterfaces
{
    interface IRecipeIngredientSupervisor
    {
        Task<IEnumerable<RecipeIngredientViewModel>> GetAllRecipeIngredientsAsync(CancellationToken ct = default);
        Task<List<RecipeIngredientViewModel>> GetRecipeIngredientsByRecipeIdAsync(Guid guid, CancellationToken ct = default);
        Task<List<RecipeIngredientViewModel>> GetRecipeIngredientsByIngredientIdAsync(Guid guid, CancellationToken ct = default);
        Task<RecipeIngredientViewModel> AddRecipeIngredientAsync(RecipeIngredientViewModel newRecipeIngredient, CancellationToken ct = default);
        Task<bool> UpdateRecipeIngredientAsync(RecipeIngredientViewModel recipeIngredient, CancellationToken ct = default);
        Task<bool> DeleteRecipeIngredientAsync(Guid guid, CancellationToken ct = default);
    }
}
