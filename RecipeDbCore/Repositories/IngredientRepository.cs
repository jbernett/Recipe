using RecipeDomain.Models;
using RecipeDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeDbCore.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        public Task<Ingredient> AddAsync(Ingredient newIngredient, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ingredient>> GetAllAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<Ingredient> GetByIdAsync(Guid id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Ingredient ingredient, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
