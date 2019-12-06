using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RecipeDomain.Models;
using RecipeDomain.Repositories;

namespace RecipeDbCore.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        public Task<Recipe> AddAsync(Recipe newRecipe, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<Recipe>> GetAllAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<Recipe> GetByIdAsync(Guid id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Recipe recipe, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
