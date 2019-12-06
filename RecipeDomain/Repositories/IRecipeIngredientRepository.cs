using RecipeDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeDomain.Repositories
{
    public interface IRecipeIngredientRepository : IDisposable
    {
        Task<List<RecipeIngredient>> GetAllAsync(CancellationToken ct = default);
        Task<List<RecipeIngredient>> GetByRecipeIdAsync(Guid id, CancellationToken ct = default);
        Task<List<RecipeIngredient>> GetByIngredientIdAsync(Guid id, CancellationToken ct = default);
        Task<RecipeIngredient> AddAsync(RecipeIngredient newRecipeIngredient, CancellationToken ct = default);
        Task<bool> UpdateAsync(RecipeIngredient recipeIngredient, CancellationToken ct = default);
        Task<bool> DeleteAsync(Guid id, CancellationToken ct = default);
    }
}
