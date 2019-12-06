using RecipeDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeDomain.Repositories
{
    public interface IIngredientRepository
    {
        Task<List<Ingredient>> GetAllAsync(CancellationToken ct = default);
        Task<Ingredient> GetByIdAsync(Guid id, CancellationToken ct = default);
        Task<Ingredient> AddAsync(Ingredient newIngredient, CancellationToken ct = default);
        Task<bool> UpdateAsync(Ingredient ingredient, CancellationToken ct = default);
        Task<bool> DeleteAsync(Guid id, CancellationToken ct = default);
    }
}
