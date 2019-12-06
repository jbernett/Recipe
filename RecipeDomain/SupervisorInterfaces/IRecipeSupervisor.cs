
using RecipeDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeDomain.SupervisorInterfaces
{
    interface IRecipeSupervisor
    {
        Task<IEnumerable<RecipeViewModel>> GetAllRecipesAsync(CancellationToken ct = default);
        Task<RecipeViewModel> GetRecipeByIdAsync(Guid guid, CancellationToken ct = default);
        Task<RecipeViewModel> AddRecipeAsync(RecipeViewModel newRecipeViewModel, CancellationToken ct = default);
        Task<bool> UpdateRecipeAsync(RecipeViewModel recipeViewModel, CancellationToken ct = default);
        Task<bool> DeleteRecipeAsync(Guid guid, CancellationToken ct = default);
    }
}
