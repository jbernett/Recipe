using RecipeDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeDomain.Repositories
{
    public interface IRecipeRepository
    {
        Task<List<Recipe>> GetAllAsync(CancellationToken ct = default);
        Task<Recipe> GetByIdAsync(Guid id, CancellationToken ct = default);
        Task<Recipe> AddAsync(Recipe newRecipe, CancellationToken ct = default);
        Task<bool> UpdateAsync(Recipe recipe, CancellationToken ct = default);
        Task<bool> DeleteAsync(Guid id, CancellationToken ct = default);
    }
}
