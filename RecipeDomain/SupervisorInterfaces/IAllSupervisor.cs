using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeDomain.SupervisorInterfaces
{
    interface IAllSupervisor : 
        
        IIngredientSupervisor, 
        IRecipeIngredientSupervisor, 
        IRecipeSupervisor
    {
    }
}
