using RecipeDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeDomain.SupervisorInterfaces
{
    interface IIngredientSupervisor
    {
        Task<IEnumerable<IngredientViewModel>> GetIngredientsAllAsync(CancellationToken ct = default);
        Task<IngredientViewModel> GetIngredientByIdAsync(Guid guid, CancellationToken ct = default);
        Task<IngredientViewModel> AddIngredientAsync(IngredientViewModel newIngredient, CancellationToken ct = default);
        Task<bool> UpdateIngredientAsync(IngredientViewModel ingredient, CancellationToken ct = default);
        Task<bool> DeleteIngredientAsync(Guid guid, CancellationToken ct = default);
    }
}
