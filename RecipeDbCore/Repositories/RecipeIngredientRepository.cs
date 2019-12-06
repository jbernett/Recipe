using RecipeDomain.Models;
using RecipeDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeDbCore.Repositories
{
    public class RecipeIngredientRepository : IRecipeIngredientRepository
    {
        public Task<RecipeIngredient> AddAsync(RecipeIngredient newRecipeIngredient, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<RecipeIngredient>> GetAllAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<RecipeIngredient>> GetByIngredientIdAsync(Guid id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<RecipeIngredient>> GetByRecipeIdAsync(Guid id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(RecipeIngredient recipeIngredient, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
